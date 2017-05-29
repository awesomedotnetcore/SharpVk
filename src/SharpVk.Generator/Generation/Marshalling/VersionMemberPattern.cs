﻿using SharpVk.Generator.Collation;
using System.Collections.Generic;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class VersionMemberPattern
        : IMemberPatternRule
    {
        private readonly NameLookup nameLookup;

        public VersionMemberPattern(NameLookup nameLookup)
        {
            this.nameLookup = nameLookup;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, MemberPatternInfo info)
        {
            if (source.Name.EndsWith("Version") && source.Type.VkName.StartsWith("uint32"))
            {
                info.Public = new TypedDefinition
                {
                    Name = source.Name,
                    Type = "Version"
                };

                info.MarshalFrom.Add(new Action
                {
                    ValueExpression = Cast("Version", DerefMember(Variable("pointer"), source.Name)),
                    TargetExpression = Member(Variable("result"), source.Name),
                });

                info.Interop = new TypedDefinition
                {
                    Name = source.Name,
                    Type = this.nameLookup.Lookup(source.Type, true)
                };

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}