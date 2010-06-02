//-----------------------------------------------------------------------
// <copyright file="SortableBindingList.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CMBC.EasyFactor.Controls
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SortableBindingCollection<T> : BindingList<T>
    {
        /// <summary>
        /// 
        /// </summary>
        private bool _isSorted;

        /// <summary>
        /// 
        /// </summary>
        private PropertyDescriptor _propertyDescriptor;

        /// <summary>
        /// 
        /// </summary>
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        public SortableBindingCollection(IList<T> list)
            : base(list)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public SortableBindingCollection()
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override bool IsSortedCore
        {
            get { return _isSorted; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override ListSortDirection SortDirectionCore
        {
            get { return _sortDirection; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _propertyDescriptor; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override bool SupportsSortingCore
        {
            get { return true; }
        }


        //?Public?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortPropertyName"></param>
        /// <param name="isAscending"></param>
        public void Sort(string sortPropertyName, bool isAscending)
        {
            _sortDirection = isAscending ? ListSortDirection.Ascending : ListSortDirection.Descending;

            _propertyDescriptor = GetPropertyDescriptor(sortPropertyName);
            ApplySortCore(_propertyDescriptor, _sortDirection);
        }

        //?Protected?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prop"></param>
        /// <param name="direction"></param>
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            _propertyDescriptor = prop;
            _sortDirection = direction;
            InnerSort();
            _isSorted = true;
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
            if (_sortDirection == ListSortDirection.Descending)
            {
                return CompareValue(_propertyDescriptor.GetValue(y), _propertyDescriptor.GetValue(x));
            }
            return CompareValue(_propertyDescriptor.GetValue(x), _propertyDescriptor.GetValue(y));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="o1"></param>
        /// <param name="o2"></param>
        /// <returns></returns>
        private static int CompareValue(object o1, object o2)
        {
            if (o1 == null)
            {
                return o2 == null ? 0 : -1;
            }
            if (o2 == null)
            {
                return 1;
            }
            if (o1 is IComparable)
            {
                return ((IComparable)o1).CompareTo(o2);
            }
            if (o2 is IComparable)
            {
                return ((IComparable)o2).CompareTo(o1);
            }
            return o1.ToString().CompareTo(o2.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static PropertyDescriptor GetPropertyDescriptor(string propertyName)
        {
            PropertyDescriptorCollection propertyCollection = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor item in propertyCollection)
            {
                if (item.Name == propertyName)
                {
                    return item;
                }
            }

            throw (new Exception("ÅÅÐò×Ö¶ÎÃû²»´æÔÚ!"));
        }

        /// <summary>
        /// 
        /// </summary>
        private void InnerSort()
        {
            var list = (Items as List<T>);
            if (list != null) list.Sort(Compare);
            ResetBindings();
        }
    }
}