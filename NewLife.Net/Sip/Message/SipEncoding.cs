﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NewLife.Net.Sip.Message
{
    /// <summary></summary>
    public class Sip : SipValueWithParams
    {
        #region 属性
        private String _ContentEncoding;
        /// <summary>属性说明</summary>
        public String ContentEncoding { get { return _ContentEncoding; } set { _ContentEncoding = value; } }
        #endregion

        #region 扩展属性
        private Double _QValue;
        /// <summary>qvalue</summary>
        public Double QValue { get { return _QValue; } set { _QValue = value; } }
        #endregion
    }
}