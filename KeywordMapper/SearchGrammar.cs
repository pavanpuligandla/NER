using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Irony.Compiler;

namespace KeywordMapper
{
    public class SearchGrammar : Grammar
    {
        //Adding Sample Comment
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public SearchGrammar()
        {
            // Terminals
            var Term = new IdentifierTerminal("Term", "!@#$%^*_'.?", "!@#$%^*_'.?0123456789");
            // The following is not very imporant, but makes scanner recognize "or" and "and" as operators, not Terms
            // The "or" and "and" operator symbols found in grammar get higher priority in scanning and are checked
            // first, before the Term terminal, so Scanner produces operator token, not Term. For our purposes it does
            // not matter, we get around without it. 
            Term.Priority = Terminal.LowestPriority;
            var Phrase = new StringLiteral("Phrase");

            // NonTerminals
            var OrExpression = new NonTerminal("OrExpression");
            var OrOperator = new NonTerminal("OrOperator");
            var AndExpression = new NonTerminal("AndExpression");
            var AndOperator = new NonTerminal("AndOperator");
            var ExcludeOperator = new NonTerminal("ExcludeOperator");
            var PrimaryExpression = new NonTerminal("PrimaryExpression");
            var ThesaurusExpression = new NonTerminal("ThesaurusExpression");
            var ThesaurusOperator = new NonTerminal("ThesaurusOperator");
            var ExactOperator = new NonTerminal("ExactOperator");
            var ExactExpression = new NonTerminal("ExactExpression");
            var ParenthesizedExpression = new NonTerminal("ParenthesizedExpression");
            var ProximityExpression = new NonTerminal("ProximityExpression");
            var ProximityList = new NonTerminal("ProximityList");

            this.Root = OrExpression;
            OrExpression.Rule = AndExpression
                              | OrExpression + OrOperator + AndExpression;
            OrOperator.Rule = Symbol("or") | "|";
            AndExpression.Rule = PrimaryExpression
                               | AndExpression + AndOperator + PrimaryExpression;
            AndOperator.Rule = Empty
                             | "and"
                             | "&"
                             | ExcludeOperator;
            ExcludeOperator.Rule = Symbol("-");
            PrimaryExpression.Rule = Term
                                   | ThesaurusExpression
                                   | ExactExpression
                                   | ParenthesizedExpression
                                   | Phrase
                                   | ProximityExpression;
            ThesaurusExpression.Rule = ThesaurusOperator + Term;
            ThesaurusOperator.Rule = Symbol("~");
            ExactExpression.Rule = ExactOperator + Term
                                 | ExactOperator + Phrase;
            ExactOperator.Rule = Symbol("+");
            ParenthesizedExpression.Rule = "(" + OrExpression + ")";
            ProximityExpression.Rule = "<" + ProximityList + ">";

            MakePlusRule(ProximityList, Term);

            RegisterPunctuation("<", ">", "(", ")");

        }

        public static DataTable ExecuteQuery(string ftsQuery)
        {
            SqlDataAdapter da = null;
            //ftsQuery = "near((examine, incidence),5)";
            
            DataTable dt = null;
            try
            {
                dt = new DataTable();

                da = new SqlDataAdapter
                    (
                        "SELECT ROW_NUMBER() OVER (ORDER BY ID) AS Number, " +
                        "   Title, " +
                        "   AbstractText " +
                        "FROM Import_New " +
                        "WHERE CONTAINS(*, '" + ftsQuery + "');",
                        connectionString
                    );
                da.SelectCommand.Parameters.Add("@ftsQuery", SqlDbType.NVarChar, 4000).Value = ftsQuery;
                da.Fill(dt);
                da.Dispose();
            }
            catch (Exception ex)
            {
                if (da != null)
                    da.Dispose();
                if (dt != null)
                    dt.Dispose();
                throw (ex);
            }
            return dt;
        }

        public enum TermType
        {
            Inflectional = 1,
            Thesaurus = 2,
            Exact = 3
        }

        public static string ConvertQuery(AstNode node)
        {
            return ConvertQuery(node, TermType.Inflectional);
        }

        //public static string ConvertQuery(ParseTreeNode node, TermType type)
        //{
        //    string result = "";
        //    // Note that some NonTerminals don't actually get into the AST tree, 
        //    // because of some Irony's optimizations - punctuation stripping and 
        //    // transient nodes elimination. For example, ParenthesizedExpression - parentheses 
        //    // symbols get stripped off as punctuation, and child expression node 
        //    // (parenthesized content) replaces the parent ParenthesizedExpression node
        //    switch (node.Term.Name)
        //    {
        //        case "BinaryExpression":
        //            string opSym = string.Empty;
        //            string op = node.ChildNodes[1].FindTokenAndGetText().ToLower();
        //            string sqlOp = "";
        //            switch (op)
        //            {
        //                case "":
        //                case "&":
        //                case "and":
        //                    sqlOp = " AND ";
        //                    type = TermType.Inflectional;
        //                    break;
        //                case "-":
        //                    sqlOp = " AND NOT ";
        //                    break;
        //                case "|":
        //                case "or":
        //                    sqlOp = " OR ";
        //                    break;
        //            }//switch

        //            result = "(" + ConvertQuery(node.ChildNodes[0], type) + sqlOp + ConvertQuery(node.ChildNodes[2], type) + ")";
        //            break;

        //        case "PrimaryExpression":
        //            result = "(" + ConvertQuery(node.ChildNodes[0], type) + ")";
        //            break;

        //        case "ProximityList":
        //            string[] tmp = new string[node.ChildNodes.Count];
        //            type = TermType.Exact;
        //            for (int i = 0; i < node.ChildNodes.Count; i++)
        //            {
        //                tmp[i] = ConvertQuery(node.ChildNodes[i], type);
        //            }
        //            result = "(" + string.Join(" NEAR ", tmp) + ")";
        //            type = TermType.Inflectional;
        //            break;

        //        case "Phrase":
        //            result = '"' + node.Token.ValueString + '"';
        //            break;

        //        case "ThesaurusExpression":
        //            result = " FORMSOF (THESAURUS, " +
        //                node.ChildNodes[1].Token.ValueString + ") ";
        //            break;

        //        case "ExactExpression":
        //            result = " \"" + node.ChildNodes[1].Token.ValueString + "\" ";
        //            break;

        //        case "Term":
        //            switch (type)
        //            {
        //                case TermType.Inflectional:
        //                    result = node.Token.ValueString;
        //                    if (result.EndsWith("*"))
        //                        result = "\"" + result + "\"";
        //                    else
        //                        result = " FORMSOF (INFLECTIONAL, " + result + ") ";
        //                    break;
        //                case TermType.Exact:
        //                    result = node.Token.ValueString;

        //                    break;
        //            }
        //            break;

        //        // This should never happen, even if input string is garbage
        //        default:
        //            throw new ApplicationException("Converter failed: unexpected term: " +
        //                node.Term.Name + ". Please investigate.");

        //    }
        //    return result;
        //}

        public static string ConvertQuery(AstNode node, TermType type)
        {
            string result = "";
            // Note that some NonTerminals don't actually get into the AST tree, 
            // because of some Irony's optimizations - punctuation stripping and 
            // node bubbling. For example, ParenthesizedExpression - parentheses 
            // symbols get stripped off as punctuation, and child expression node 
            // (parenthesized content) replaces the parent ParExpr node (the 
            // child is "bubbled up").
            switch (node.Term.Name)
            {
                case "OrExpression":
                    result = "(" + ConvertQuery(node.ChildNodes[0], type) + " OR " +
                        ConvertQuery(node.ChildNodes[2], type) + ")";
                    break;

                case "AndExpression":
                    AstNode tmp2 = node.ChildNodes[1];
                    string opName = tmp2.Term.Name;
                    string andop = "";

                    if (opName == "-")
                    {
                        andop += " AND NOT ";
                    }
                    else
                    {
                        andop = " AND ";
                        type = TermType.Inflectional;
                    }
                    result = "(" + ConvertQuery(node.ChildNodes[0], type) + andop +
                        ConvertQuery(node.ChildNodes[2], type) + ")";
                    type = TermType.Inflectional;
                    break;

                case "PrimaryExpression":
                    result = "(" + ConvertQuery(node.ChildNodes[0], type) + ")";
                    break;

                case "ProximityList":
                    string[] tmp = new string[node.ChildNodes.Count];
                    type = TermType.Exact;
                    for (int i = 0; i < node.ChildNodes.Count; i++)
                    {
                        tmp[i] = ConvertQuery(node.ChildNodes[i], type);
                    }
                    result = "(" + string.Join(" NEAR ", tmp) + ")";
                    type = TermType.Inflectional;
                    break;

                case "Phrase":
                    result = '"' + ((Token)node).ValueString + '"';
                    break;

                case "ThesaurusExpression":
                    result = " FORMSOF (THESAURUS, " +
                        ((Token)node.ChildNodes[1]).ValueString + ") ";
                    break;

                case "ExactExpression":
                    result = " \"" + ((Token)node.ChildNodes[1]).ValueString + "\" ";
                    break;

                case "Term":
                    switch (type)
                    {
                        case TermType.Inflectional:
                            result = ((Token)node).ValueString;
                            if (result.EndsWith("*"))
                                result = "\"" + result + "\"";
                            else
                                result = " FORMSOF (INFLECTIONAL, " + result + ") ";
                            break;
                        case TermType.Exact:
                            result = ((Token)node).ValueString;

                            break;
                    }
                    break;

                // This should never happen, even if input string is garbage
                default:
                    throw new ApplicationException("Converter failed: unexpected term: " +
                        node.Term.Name + ". Please investigate.");

            }
            return result;
        }

    }

}
