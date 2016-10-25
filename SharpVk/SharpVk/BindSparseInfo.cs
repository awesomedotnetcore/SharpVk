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

namespace SharpVk
{
    /// <summary>
    /// Structure specifying a sparse binding operation.
    /// </summary>
    public struct BindSparseInfo
    {
        /// <summary>
        /// pname:pWaitSemaphores is a pointer to an array of semaphores upon
        /// which to wait on before the sparse binding operations for this
        /// batch begin execution. If semaphores to wait on are provided, they
        /// define a &lt;&lt;synchronization-semaphores-waiting, semaphore wait
        /// operation&gt;&gt;.
        /// </summary>
        public Semaphore[] WaitSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pBufferBinds is a pointer to an array of
        /// slink:VkSparseBufferMemoryBindInfo structures.
        /// </summary>
        public SparseBufferMemoryBindInfo[] BufferBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pImageOpaqueBinds is a pointer to an array of
        /// slink:VkSparseImageOpaqueMemoryBindInfo structures, indicating
        /// opaque sparse image bindings to perform.
        /// </summary>
        public SparseImageOpaqueMemoryBindInfo[] ImageOpaqueBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pImageBinds is a pointer to an array of
        /// slink:VkSparseImageMemoryBindInfo structures, indicating sparse
        /// image bindings to perform.
        /// </summary>
        public SparseImageMemoryBindInfo[] ImageBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSignalSemaphores is a pointer to an array of semaphores
        /// which will be signaled when the sparse binding operations for this
        /// batch have completed execution. If semaphores to be signaled are
        /// provided, they define a
        /// &lt;&lt;synchronization-semaphores-signaling, semaphore signal
        /// operation&gt;&gt;.
        /// </summary>
        public Semaphore[] SignalSemaphores
        {
            get;
            set;
        }
        
        internal unsafe Interop.BindSparseInfo Pack()
        {
            Interop.BindSparseInfo result = default(Interop.BindSparseInfo);
            result.SType = StructureType.BindSparseInfo;
            
            //WaitSemaphores
            if (this.WaitSemaphores != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.Semaphore>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.Semaphore>(this.WaitSemaphores.Length);
                for (int index = 0; index < this.WaitSemaphores.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.WaitSemaphores[index].Pack(), pointer + (size * index), false);
                }
                result.WaitSemaphores = (Interop.Semaphore*)pointer.ToPointer();
            }
            else
            {
                result.WaitSemaphores = null;
            }
            
            //BufferBinds
            if (this.BufferBinds != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SparseBufferMemoryBindInfo>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.SparseBufferMemoryBindInfo>(this.BufferBinds.Length);
                for (int index = 0; index < this.BufferBinds.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.BufferBinds[index].Pack(), pointer + (size * index), false);
                }
                result.BufferBinds = (Interop.SparseBufferMemoryBindInfo*)pointer.ToPointer();
            }
            else
            {
                result.BufferBinds = null;
            }
            
            //ImageOpaqueBinds
            if (this.ImageOpaqueBinds != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SparseImageOpaqueMemoryBindInfo>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.SparseImageOpaqueMemoryBindInfo>(this.ImageOpaqueBinds.Length);
                for (int index = 0; index < this.ImageOpaqueBinds.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.ImageOpaqueBinds[index].Pack(), pointer + (size * index), false);
                }
                result.ImageOpaqueBinds = (Interop.SparseImageOpaqueMemoryBindInfo*)pointer.ToPointer();
            }
            else
            {
                result.ImageOpaqueBinds = null;
            }
            
            //ImageBinds
            if (this.ImageBinds != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SparseImageMemoryBindInfo>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.SparseImageMemoryBindInfo>(this.ImageBinds.Length);
                for (int index = 0; index < this.ImageBinds.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.ImageBinds[index].Pack(), pointer + (size * index), false);
                }
                result.ImageBinds = (Interop.SparseImageMemoryBindInfo*)pointer.ToPointer();
            }
            else
            {
                result.ImageBinds = null;
            }
            
            //SignalSemaphores
            if (this.SignalSemaphores != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.Semaphore>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.Semaphore>(this.SignalSemaphores.Length);
                for (int index = 0; index < this.SignalSemaphores.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.SignalSemaphores[index].Pack(), pointer + (size * index), false);
                }
                result.SignalSemaphores = (Interop.Semaphore*)pointer.ToPointer();
            }
            else
            {
                result.SignalSemaphores = null;
            }
            result.WaitSemaphoreCount = (uint)(this.WaitSemaphores?.Length ?? 0);
            result.BufferBindCount = (uint)(this.BufferBinds?.Length ?? 0);
            result.ImageOpaqueBindCount = (uint)(this.ImageOpaqueBinds?.Length ?? 0);
            result.ImageBindCount = (uint)(this.ImageBinds?.Length ?? 0);
            result.SignalSemaphoreCount = (uint)(this.SignalSemaphores?.Length ?? 0);
            return result;
        }
        
        internal unsafe Interop.BindSparseInfo* MarshalTo()
        {
            return (Interop.BindSparseInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
