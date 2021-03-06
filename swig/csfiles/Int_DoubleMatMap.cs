//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SharpFace
{

    public class Int_DoubleMatMap : global::System.IDisposable
        , global::System.Collections.Generic.IDictionary<int, SWIGTYPE_p_cv__Mat_T_double_t>
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal Int_DoubleMatMap(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Int_DoubleMatMap obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~Int_DoubleMatMap()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock(this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        LandmarkDetectorPINVOKE.delete_Int_DoubleMatMap(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }


        public SWIGTYPE_p_cv__Mat_T_double_t this[int key]
        {
            get
            {
                return getitem(key);
            }

            set
            {
                setitem(key, value);
            }
        }

        public bool TryGetValue(int key, out SWIGTYPE_p_cv__Mat_T_double_t value)
        {
            if (this.ContainsKey(key))
            {
                value = this[key];
                return true;
            }
            value = default(SWIGTYPE_p_cv__Mat_T_double_t);
            return false;
        }

        public int Count
        {
            get
            {
                return (int)size();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public global::System.Collections.Generic.ICollection<int> Keys
        {
            get
            {
                global::System.Collections.Generic.ICollection<int> keys = new global::System.Collections.Generic.List<int>();
                int size = this.Count;
                if (size > 0)
                {
                    global::System.IntPtr iter = create_iterator_begin();
                    for (int i = 0; i < size; i++)
                    {
                        keys.Add(get_next_key(iter));
                    }
                    destroy_iterator(iter);
                }
                return keys;
            }
        }

        public global::System.Collections.Generic.ICollection<SWIGTYPE_p_cv__Mat_T_double_t> Values
        {
            get
            {
                global::System.Collections.Generic.ICollection<SWIGTYPE_p_cv__Mat_T_double_t> vals = new global::System.Collections.Generic.List<SWIGTYPE_p_cv__Mat_T_double_t>();
                foreach (global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t> pair in this)
                {
                    vals.Add(pair.Value);
                }
                return vals;
            }
        }

        public void Add(global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t> item)
        {
            Add(item.Key, item.Value);
        }

        public bool Remove(global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t> item)
        {
            if (Contains(item))
            {
                return Remove(item.Key);
            }
            else
            {
                return false;
            }
        }

        public bool Contains(global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t> item)
        {
            if (this[item.Key] == item.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CopyTo(global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t>[] array)
        {
            CopyTo(array, 0);
        }

        public void CopyTo(global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t>[] array, int arrayIndex)
        {
            if (array == null)
                throw new global::System.ArgumentNullException("array");
            if (arrayIndex < 0)
                throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
            if (array.Rank > 1)
                throw new global::System.ArgumentException("Multi dimensional array.", "array");
            if (arrayIndex+this.Count > array.Length)
                throw new global::System.ArgumentException("Number of elements to copy is too large.");

            global::System.Collections.Generic.IList<int> keyList = new global::System.Collections.Generic.List<int>(this.Keys);
            for (int i = 0; i < keyList.Count; i++)
            {
                int currentKey = keyList[i];
                array.SetValue(new global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t>(currentKey, this[currentKey]), arrayIndex+i);
            }
        }

        global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t>>.GetEnumerator()
        {
            return new Int_DoubleMatMapEnumerator(this);
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return new Int_DoubleMatMapEnumerator(this);
        }

        public Int_DoubleMatMapEnumerator GetEnumerator()
        {
            return new Int_DoubleMatMapEnumerator(this);
        }

        // Type-safe enumerator
        /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
        /// whenever the collection is modified. This has been done for changes in the size of the
        /// collection but not when one of the elements of the collection is modified as it is a bit
        /// tricky to detect unmanaged code that modifies the collection under our feet.
        public sealed class Int_DoubleMatMapEnumerator : global::System.Collections.IEnumerator,
            global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t>>
        {
            private Int_DoubleMatMap collectionRef;
            private global::System.Collections.Generic.IList<int> keyCollection;
            private int currentIndex;
            private object currentObject;
            private int currentSize;

            public Int_DoubleMatMapEnumerator(Int_DoubleMatMap collection)
            {
                collectionRef = collection;
                keyCollection = new global::System.Collections.Generic.List<int>(collection.Keys);
                currentIndex = -1;
                currentObject = null;
                currentSize = collectionRef.Count;
            }

            // Type-safe iterator Current
            public global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t> Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new global::System.InvalidOperationException("Enumeration not started.");
                    if (currentIndex > currentSize - 1)
                        throw new global::System.InvalidOperationException("Enumeration finished.");
                    if (currentObject == null)
                        throw new global::System.InvalidOperationException("Collection modified.");
                    return (global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t>)currentObject;
                }
            }

            // Type-unsafe IEnumerator.Current
            object global::System.Collections.IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public bool MoveNext()
            {
                int size = collectionRef.Count;
                bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
                if (moveOkay)
                {
                    currentIndex++;
                    int currentKey = keyCollection[currentIndex];
                    currentObject = new global::System.Collections.Generic.KeyValuePair<int, SWIGTYPE_p_cv__Mat_T_double_t>(currentKey, collectionRef[currentKey]);
                }
                else
                {
                    currentObject = null;
                }
                return moveOkay;
            }

            public void Reset()
            {
                currentIndex = -1;
                currentObject = null;
                if (collectionRef.Count != currentSize)
                {
                    throw new global::System.InvalidOperationException("Collection modified.");
                }
            }

            public void Dispose()
            {
                currentIndex = -1;
                currentObject = null;
            }
        }


        public Int_DoubleMatMap() : this(LandmarkDetectorPINVOKE.new_Int_DoubleMatMap__SWIG_0(), true)
        {
        }

        public Int_DoubleMatMap(Int_DoubleMatMap other) : this(LandmarkDetectorPINVOKE.new_Int_DoubleMatMap__SWIG_1(Int_DoubleMatMap.getCPtr(other)), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        private uint size()
        {
            uint ret = LandmarkDetectorPINVOKE.Int_DoubleMatMap_size(swigCPtr);
            return ret;
        }

        public bool empty()
        {
            bool ret = LandmarkDetectorPINVOKE.Int_DoubleMatMap_empty(swigCPtr);
            return ret;
        }

        public void Clear()
        {
            LandmarkDetectorPINVOKE.Int_DoubleMatMap_Clear(swigCPtr);
        }

        private SWIGTYPE_p_cv__Mat_T_double_t getitem(int key)
        {
            SWIGTYPE_p_cv__Mat_T_double_t ret = new SWIGTYPE_p_cv__Mat_T_double_t(LandmarkDetectorPINVOKE.Int_DoubleMatMap_getitem(swigCPtr, key), false);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private void setitem(int key, SWIGTYPE_p_cv__Mat_T_double_t x)
        {
            LandmarkDetectorPINVOKE.Int_DoubleMatMap_setitem(swigCPtr, key, SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(x));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool ContainsKey(int key)
        {
            bool ret = LandmarkDetectorPINVOKE.Int_DoubleMatMap_ContainsKey(swigCPtr, key);
            return ret;
        }

        public void Add(int key, SWIGTYPE_p_cv__Mat_T_double_t val)
        {
            LandmarkDetectorPINVOKE.Int_DoubleMatMap_Add(swigCPtr, key, SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(val));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool Remove(int key)
        {
            bool ret = LandmarkDetectorPINVOKE.Int_DoubleMatMap_Remove(swigCPtr, key);
            return ret;
        }

        private global::System.IntPtr create_iterator_begin()
        {
            global::System.IntPtr ret = LandmarkDetectorPINVOKE.Int_DoubleMatMap_create_iterator_begin(swigCPtr);
            return ret;
        }

        private int get_next_key(global::System.IntPtr swigiterator)
        {
            int ret = LandmarkDetectorPINVOKE.Int_DoubleMatMap_get_next_key(swigCPtr, swigiterator);
            return ret;
        }

        private void destroy_iterator(global::System.IntPtr swigiterator)
        {
            LandmarkDetectorPINVOKE.Int_DoubleMatMap_destroy_iterator(swigCPtr, swigiterator);
        }

    }

}
