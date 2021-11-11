// Copyright (c) .NET Foundation and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using ClangSharp.Interop;

namespace ClangSharp
{
    public sealed class ObjCBridgedCastExpr : ExplicitCastExpr
    {
        internal ObjCBridgedCastExpr(CXCursor handle) : base(handle, CXCursorKind.CXCursor_ObjCBridgedCastExpr, CX_StmtClass.CX_StmtClass_ObjCBridgedCastExpr)
        {
        }

        public string BridgeKindName => Handle.Name.CString;
    }
}
