// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2018
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

namespace SharpVk.Khronos
{
    /// <summary>
    /// Structure specifying image creation parameters.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceImageFormatInfo2
    {
        /// <summary>
        /// The image format, corresponding to ImageCreateInfo::format.
        /// </summary>
        public SharpVk.Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// The image type, corresponding to ImageCreateInfo::imageType.
        /// </summary>
        public SharpVk.ImageType Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// The image tiling, corresponding to ImageCreateInfo::tiling.
        /// </summary>
        public SharpVk.ImageTiling Tiling
        {
            get;
            set;
        }
        
        /// <summary>
        /// The intended usage of the image, corresponding to
        /// ImageCreateInfo::usage.
        /// </summary>
        public SharpVk.ImageUsageFlags Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// A bitmask describing additional parameters of the image,
        /// corresponding to ImageCreateInfo::flags.
        /// </summary>
        public SharpVk.ImageCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.PhysicalDeviceImageFormatInfo2* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceImageFormatInfo2;
            pointer->Next = null;
            pointer->Format = this.Format;
            pointer->Type = this.Type;
            pointer->Tiling = this.Tiling;
            pointer->Usage = this.Usage;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.ImageCreateFlags);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceImageFormatInfo2 MarshalFrom(SharpVk.Interop.Khronos.PhysicalDeviceImageFormatInfo2* pointer)
        {
            PhysicalDeviceImageFormatInfo2 result = default(PhysicalDeviceImageFormatInfo2);
            result.Format = pointer->Format;
            result.Type = pointer->Type;
            result.Tiling = pointer->Tiling;
            result.Usage = pointer->Usage;
            result.Flags = pointer->Flags;
            return result;
        }
    }
}
