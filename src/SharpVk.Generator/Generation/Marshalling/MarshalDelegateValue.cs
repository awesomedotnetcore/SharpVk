﻿using SharpVk.Emit;
using SharpVk.Generator.Collation;
using System;
using System.Collections.Generic;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalDelegateValue
        : IMarshalValueRule
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;

        public MarshalDelegateValue(NameLookup nameLookup, Dictionary<string, TypeDeclaration> typeData)
        {
            this.nameLookup = nameLookup;
            this.typeData = typeData;
        }

        public bool Apply(TypeReference type, out (string, MemberActionType, Func<Action<ExpressionBuilder>, Action<ExpressionBuilder>>) result)
        {
            var typePattern = this.typeData[type.VkName].Pattern;

            if (typePattern == TypePattern.Delegate)
            {
                result = (this.nameLookup.Lookup(type, false),
                            MemberActionType.AssignToDeref,
                            value => StaticCall("System.Runtime.InteropServices.Marshal", "GetFunctionPointerForDelegate", value));

                return true;
            }
            else
            {
                result = (null, MemberActionType.AssignToDeref, null);

                return false;
            }
        }
    }
}
