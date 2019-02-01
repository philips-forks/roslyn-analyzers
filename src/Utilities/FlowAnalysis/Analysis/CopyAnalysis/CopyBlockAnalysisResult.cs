﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.FlowAnalysis.DataFlow.CopyAnalysis
{
    /// <summary>
    /// Result from execution of <see cref="CopyAnalysis"/> on a basic block.
    /// It store copy values for each <see cref="AnalysisEntity"/> at the start and end of the basic block.
    /// </summary>
    internal sealed class CopyBlockAnalysisResult : AbstractBlockAnalysisResult
    {
        public CopyBlockAnalysisResult(BasicBlock basicBlock, CopyAnalysisData blockAnalysisData)
            : base(basicBlock)
        {
            Data = blockAnalysisData?.CoreAnalysisData.ToImmutableDictionary() ?? ImmutableDictionary<AnalysisEntity, CopyAbstractValue>.Empty;
            IsReachable = blockAnalysisData?.IsReachableBlockData ?? true;
        }

        public ImmutableDictionary<AnalysisEntity, CopyAbstractValue> Data { get; }
        public bool IsReachable { get; }
    }
}
