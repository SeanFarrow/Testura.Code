﻿using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Testura.Code.Models
{
    public class Invocation
    {
        private readonly InvocationExpressionSyntax _invocation;

        public Invocation(InvocationExpressionSyntax invocation)
        {
            _invocation = invocation;
        }

        public ExpressionStatementSyntax AsExpressionStatement()
        {
            return ExpressionStatement(_invocation);
        }

        public InvocationExpressionSyntax AsInvocationStatment()
        {
            return _invocation;
        }
    }
}