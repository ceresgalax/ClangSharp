// Copyright (c) .NET Foundation and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.
// Ported from https://github.com/microsoft/ClangSharp/blob/main/sources/libClangSharp

namespace ClangSharp.Interop
{
    public enum CX_CastKind
    {
        CX_CK_Invalid,
        CX_CK_Dependent,
        CX_CK_BitCast,
        CX_CK_LValueBitCast,
        CX_CK_LValueToRValueBitCast,
        CX_CK_LValueToRValue,
        CX_CK_NoOp,
        CX_CK_BaseToDerived,
        CX_CK_DerivedToBase,
        CX_CK_UncheckedDerivedToBase,
        CX_CK_Dynamic,
        CX_CK_ToUnion,
        CX_CK_ArrayToPointerDecay,
        CX_CK_FunctionToPointerDecay,
        CX_CK_NullToPointer,
        CX_CK_NullToMemberPointer,
        CX_CK_BaseToDerivedMemberPointer,
        CX_CK_DerivedToBaseMemberPointer,
        CX_CK_MemberPointerToBoolean,
        CX_CK_ReinterpretMemberPointer,
        CX_CK_UserDefinedConversion,
        CX_CK_ConstructorConversion,
        CX_CK_IntegralToPointer,
        CX_CK_PointerToIntegral,
        CX_CK_PointerToBoolean,
        CX_CK_ToVoid,
        CX_CK_MatrixCast,
        CX_CK_VectorSplat,
        CX_CK_IntegralCast,
        CX_CK_IntegralToBoolean,
        CX_CK_IntegralToFloating,
        CX_CK_FloatingToFixedPoint,
        CX_CK_FixedPointToFloating,
        CX_CK_FixedPointCast,
        CX_CK_FixedPointToIntegral,
        CX_CK_IntegralToFixedPoint,
        CX_CK_FixedPointToBoolean,
        CX_CK_FloatingToIntegral,
        CX_CK_FloatingToBoolean,
        CX_CK_BooleanToSignedIntegral,
        CX_CK_FloatingCast,
        CX_CK_CPointerToObjCPointerCast,
        CX_CK_BlockPointerToObjCPointerCast,
        CX_CK_AnyPointerToBlockPointerCast,
        CX_CK_ObjCObjectLValueCast,
        CX_CK_FloatingRealToComplex,
        CX_CK_FloatingComplexToReal,
        CX_CK_FloatingComplexToBoolean,
        CX_CK_FloatingComplexCast,
        CX_CK_FloatingComplexToIntegralComplex,
        CX_CK_IntegralRealToComplex,
        CX_CK_IntegralComplexToReal,
        CX_CK_IntegralComplexToBoolean,
        CX_CK_IntegralComplexCast,
        CX_CK_IntegralComplexToFloatingComplex,
        CX_CK_ARCProduceObject,
        CX_CK_ARCConsumeObject,
        CX_CK_ARCReclaimReturnedObject,
        CX_CK_ARCExtendBlockObject,
        CX_CK_AtomicToNonAtomic,
        CX_CK_NonAtomicToAtomic,
        CX_CK_CopyAndAutoreleaseBlockObject,
        CX_CK_BuiltinFnToFnPtr,
        CX_CK_ZeroToOCLOpaqueType,
        CX_CK_AddressSpaceConversion,
        CX_CK_IntToOCLSampler,
    }
}
