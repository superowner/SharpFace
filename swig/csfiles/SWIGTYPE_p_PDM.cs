//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SharpFace
{

    public class SWIGTYPE_p_PDM
    {

        private volatile System.IntPtr swigCPtr;

        public SWIGTYPE_p_PDM(System.Runtime.InteropServices.HandleRef hRef, bool meanless) : this(hRef.Handle)
        {

        }

        public SWIGTYPE_p_PDM(System.Runtime.InteropServices.HandleRef hRef) : this(hRef, true)
        {

        }

        public SWIGTYPE_p_PDM(System.IntPtr ptr, bool meanless) : this(ptr)
        {

        }

        public SWIGTYPE_p_PDM(System.IntPtr ptr)
        {
            swigCPtr = ptr;
        }

        public SWIGTYPE_p_PDM()
        {
            swigCPtr = System.IntPtr.Zero;
        }

        public static System.Runtime.InteropServices.HandleRef getCPtr(SWIGTYPE_p_PDM obj)
        {
            return new System.Runtime.InteropServices.HandleRef(obj, obj.swigCPtr);
        }

        public System.IntPtr Pointer => swigCPtr;
    }

}
