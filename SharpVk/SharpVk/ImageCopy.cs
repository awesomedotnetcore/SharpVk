// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
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
using System.Text;

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure specifying an image copy operation.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The pname:aspectMask member of pname:srcSubresource
    /// and pname:dstSubresource must: match * The pname:layerCount member of
    /// pname:srcSubresource and pname:dstSubresource must: match * If either
    /// of the calling command's pname:srcImage or pname:dstImage parameters
    /// are of elink:VkImageType ename:VK_IMAGE_TYPE_3D, the
    /// pname:baseArrayLayer and pname:layerCount members of both
    /// pname:srcSubresource and pname:dstSubresource must: be `0` and `1`,
    /// respectively * The pname:aspectMask member of pname:srcSubresource
    /// must: specify aspects present in the calling command's pname:srcImage *
    /// The pname:aspectMask member of pname:dstSubresource must: specify
    /// aspects present in the calling command's pname:dstImage *
    /// pname:srcOffset.x and (pname:extent.width + pname:srcOffset.x) must:
    /// both be greater than or equal to `0` and less than or equal to the
    /// source image subresource width * pname:srcOffset.y and
    /// (pname:extent.height + pname:srcOffset.y) must: both be greater than or
    /// equal to `0` and less than or equal to the source image subresource
    /// height ** If the calling command's pname:srcImage is of type
    /// ename:VK_IMAGE_TYPE_1D, then pname:srcOffset.y must: be `0` and
    /// pname:extent.height must: be `1`. * pname:srcOffset.z and
    /// (pname:extent.depth + pname:srcOffset.z) must: both be greater than or
    /// equal to `0` and less than or equal to the source image subresource
    /// depth ** If the calling command's pname:srcImage is of type
    /// ename:VK_IMAGE_TYPE_1D or ename:VK_IMAGE_TYPE_2D, then
    /// pname:srcOffset.z must: be `0` and pname:extent.depth must: be `1`. *
    /// pname:dstOffset.x and (pname:extent.width + pname:dstOffset.x) must:
    /// both be greater than or equal to `0` and less than or equal to the
    /// destination image subresource width * pname:dstOffset.y and
    /// (pname:extent.height + pname:dstOffset.y) must: both be greater than or
    /// equal to `0` and less than or equal to the destination image
    /// subresource height ** If the calling command's pname:dstImage is of
    /// type ename:VK_IMAGE_TYPE_1D, then pname:dstOffset.y must: be `0` and
    /// pname:extent.height must: be `1`. * pname:dstOffset.z and
    /// (pname:extent.depth + pname:dstOffset.z) must: both be greater than or
    /// equal to `0` and less than or equal to the destination image
    /// subresource depth ** If the calling command's pname:dstImage is of type
    /// ename:VK_IMAGE_TYPE_1D or ename:VK_IMAGE_TYPE_2D, then
    /// pname:dstOffset.z must: be `0` and pname:extent.depth must: be `1`. *
    /// If the calling command's pname:srcImage is a compressed format image:
    /// ** all members of pname:srcOffset must: be a multiple of the
    /// corresponding dimensions of the compressed texel block **
    /// pname:extent.width must: be a multiple of the compressed texel block
    /// width or (pname:extent.width + pname:srcOffset.x) must: equal the
    /// source image subresource width ** pname:extent.height must: be a
    /// multiple of the compressed texel block height or (pname:extent.height +
    /// pname:srcOffset.y) must: equal the source image subresource height **
    /// pname:extent.depth must: be a multiple of the compressed texel block
    /// depth or (pname:extent.depth + pname:srcOffset.z) must: equal the
    /// source image subresource depth * If the calling command's
    /// pname:dstImage is a compressed format image: ** all members of
    /// pname:dstOffset must: be a multiple of the corresponding dimensions of
    /// the compressed texel block ** pname:extent.width must: be a multiple of
    /// the compressed texel block width or (pname:extent.width +
    /// pname:dstOffset.x) must: equal the destination image subresource width
    /// ** pname:extent.height must: be a multiple of the compressed texel
    /// block height or (pname:extent.height + pname:dstOffset.y) must: equal
    /// the destination image subresource height ** pname:extent.depth must: be
    /// a multiple of the compressed texel block depth or (pname:extent.depth +
    /// pname:dstOffset.z) must: equal the destination image subresource depth
    /// * pname:srcOffset, pname:dstOffset, and pname:extent must: respect the
    /// image transfer granularity requirements of the queue family that it
    /// will be submitted against, as described in
    /// &lt;&lt;devsandqueues-physical-device-enumeration,Physical Device
    /// Enumeration&gt;&gt; ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageCopy
    {
        /// <summary>
        /// pname:srcSubresource and pname:dstSubresource are
        /// slink:VkImageSubresourceLayers structures specifying the image
        /// subresources of the images used for the source and destination
        /// image data, respectively.
        /// </summary>
        public ImageSubresourceLayers SourceSubresource; 
        
        /// <summary>
        /// pname:srcOffset and pname:dstOffset select the initial x, y, and z
        /// offsets in texels of the sub-regions of the source and destination
        /// image data.
        /// </summary>
        public Offset3D SourceOffset; 
        
        /// <summary>
        /// -
        /// </summary>
        public ImageSubresourceLayers DestinationSubresource; 
        
        /// <summary>
        /// -
        /// </summary>
        public Offset3D DestinationOffset; 
        
        /// <summary>
        /// pname:extent is the size in texels of the source image to copy in
        /// pname:width, pname:height and pname:depth.
        /// </summary>
        public Extent3D Extent; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("ImageCopy");
            builder.AppendLine("{");
            builder.AppendLine($"SourceSubresource: {this.SourceSubresource}");
            builder.AppendLine($"SourceOffset: {this.SourceOffset}");
            builder.AppendLine($"DestinationSubresource: {this.DestinationSubresource}");
            builder.AppendLine($"DestinationOffset: {this.DestinationOffset}");
            builder.AppendLine($"Extent: {this.Extent}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
