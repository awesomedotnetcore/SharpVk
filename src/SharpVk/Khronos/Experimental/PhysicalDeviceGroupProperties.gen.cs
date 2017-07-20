// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;
using System.Runtime.InteropServices;

namespace SharpVk.Khronos.Experimental
{
    /// <summary>
    /// Structure specifying physical device group properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceGroupProperties
    {
        /// <summary>
        /// An array of physical device handles representing all physical
        /// devices in the group. The first physicalDeviceCount elements of the
        /// array will be valid.
        /// </summary>
        public SharpVk.PhysicalDevice[] PhysicalDevices
        {
            get;
            set;
        }
        
        /// <summary>
        /// Indicates whether logical devices created from the group support
        /// allocating device memory on a subset of devices, via the deviceMask
        /// member of the MemoryAllocateFlagsInfoKHX. If this is VK_FALSE, then
        /// all device memory allocations are made across all physical devices
        /// in the group. If physicalDeviceCount is `1`, then subsetAllocation
        /// must be VK_FALSE.
        /// </summary>
        public bool SubsetAllocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceGroupProperties MarshalFrom(SharpVk.Interop.Khronos.Experimental.PhysicalDeviceGroupProperties* pointer)
        {
            PhysicalDeviceGroupProperties result = default(PhysicalDeviceGroupProperties);
            if (pointer->PhysicalDeviceCount != 0)
            {
                var fieldPointer = new SharpVk.PhysicalDevice[(uint)(pointer->PhysicalDeviceCount)];
                for(int index = 0; index < (uint)(pointer->PhysicalDeviceCount); index++)
                {
                    fieldPointer[index] = new SharpVk.PhysicalDevice(default(SharpVk.Instance), (&(pointer->PhysicalDevices_0))[index]);
                }
                result.PhysicalDevices = fieldPointer;
            }
            else
            {
                result.PhysicalDevices = null;
            }
            result.SubsetAllocation = pointer->SubsetAllocation;
            return result;
        }
    }
}
