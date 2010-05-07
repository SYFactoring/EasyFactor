//-----------------------------------------------------------------------
// <copyright file="SortableBindingList.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Controls
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SortableBindingList<T> : BindingList<T>
    {
		#region?Fields?(3)?

        /// <summary>
        /// 
        /// </summary>
        private bool isSorted;
        /// <summary>
        /// 
        /// </summary>
        private PropertyDescriptor propertyDescriptor;
        /// <summary>
        /// 
        /// </summary>
        private ListSortDirection sortDirection = ListSortDirection.Ascending;

		#endregion?Fields?

		#region?Constructors?(2)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        public SortableBindingList(IList<T> t) : base(t) { }

        /// <summary>
        /// 
        /// </summary>
        public SortableBindingList() : base() { }

		#endregion?Constructors?

		#region?Properties?(4)?

        /// <summary>
        /// 
        /// </summary>
        protected override bool IsSortedCore
        {
            get
            {
                return isSorted;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override ListSortDirection SortDirectionCore
        {
            get
            {
                return sortDirection;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override PropertyDescriptor SortPropertyCore
        {
            get
            {
                return propertyDescriptor;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override bool SupportsSortingCore
        {
            get
            {
                return true;
            }
        }

		#endregion?Properties?

		#region?Methods?(6)?

		//?Public?Methods?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortPropertyName"></param>
        /// <param name="isAscending"></param>
        public void Sort(string sortPropertyName, bool isAscending)
        {
            if (isAscending)
            {
                sortDirection = ListSortDirection.Ascending;
            }
            else
            {
                sortDirection = ListSortDirection.Descending;
            }

            propertyDescriptor = GetPropertyDescriptor(sortPropertyName);
            ApplySortCore(propertyDescriptor, sortDirection);
        }
		//?Protected?Methods?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prop"></param>
        /// <param name="direction"></param>
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            propertyDescriptor = prop;
            sortDirection = direction;
            InnerSort();
            isSorted = true;
        }
		//?Private?Methods?(4)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private int Compare(T x, T y)
        {
            if (sortDirection == ListSortDirection.Descending)
            {
                return CompareValue(propertyDescriptor.GetValue(y), propertyDescriptor.GetValue(x));
            }
            else
            {
                return CompareValue(propertyDescriptor.GetValue(x), propertyDescriptor.GetValue(y));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="o1"></param>
        /// <param name="o2"></param>
        /// <returns></returns>
        static int CompareValue(object o1, object o2)
        {
            if (o1 == null)
            {
                return o2 == null ? 0 : -1;
            }
            else if (o2 == null)
            {
                return 1;
            }
            else if (o1 is IComparable)
            {
                return ((IComparable)o1).CompareTo(o2);
            }
            else if (o2 is IComparable)
            {
                return ((IComparable)o2).CompareTo(o1);
            }
            else
                return o1.ToString().CompareTo(o2.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private PropertyDescriptor GetPropertyDescriptor(string propertyName)
        {
            bool findName = false;
            PropertyDescriptorCollection propertyCollection = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor item in propertyCollection)
            {
                if (item.Name == propertyName)
                {
                    findName = true;
                    return item;
                }
            }

            if (!findName)
            {
                throw (new Exception("ÅÅÐò×Ö¶ÎÃû²»´æÔÚ!"));
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void InnerSort()
        {
            List<T> list = (this.Items as List<T>);
            list.Sort(Compare);
            ResetBindings();
        }

		#endregion?Methods?
    }
}
