﻿using NPBehave;
using UnityEngine;
using XNode;
using Node = XNode.Node;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_NPBehave_Node
{
    public abstract class ClockNode:ANPBehaveNode<ClockNode>
    {
        public Clock Clock { get; protected set; }
    }
}