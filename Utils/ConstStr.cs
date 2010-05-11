//-----------------------------------------------------------------------
// <copyright file="ConstStr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Utils.ConstStr
{

    /// <summary>
    /// 
    /// </summary>
    public sealed class MESSAGE
    {
        #region?Fields?(4)?

        /// <summary>
        /// ���ݸ��³ɹ�
        /// </summary>
        public static readonly const string DATA_UPDATE_SUCCESS = "���ݸ��³ɹ�";

        /// <summary>
        /// 
        /// </summary>
        public static readonly const string MAIN_DEFAULT = "��ӭʹ���й��������б�����Ӫϵͳ";
        /// <summary>
        /// ��ʾ
        /// </summary>
        public static readonly const string TITLE_INFORMATION = "��ʾ";
        /// <summary>
        /// ����
        /// </summary>
        public static readonly const string TITLE_WARNING = "����";

        #endregion?Fields?

        #region?Constructors?(1)?

        private MESSAGE()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class CLIENT_CREDIT_LINE
    {
        #region?Fields?(3)?

        /// <summary>
        /// ����Ч
        /// </summary>
        public static readonly const string AVAILABILITY = "����Ч";
        /// <summary>
        /// �ѹ���
        /// </summary>
        public static readonly const string EXPIRY = "�ѹ���";
        /// <summary>
        /// �Ѷ���
        /// </summary>
        public static readonly const string FREEZE = "�Ѷ���";

        #endregion?Fields?

        #region?Constructors?(1)?

        private CLIENT_CREDIT_LINE()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class CONTRACT
    {
        #region?Fields?(2)?

        /// <summary>
        /// ����Ч
        /// </summary>
        public static readonly const string AVAILABILITY = "����Ч";
        /// <summary>
        /// �ѹ���
        /// </summary>
        public static readonly const string EXPIRY = "�ѹ���";

        #endregion?Fields?

        #region?Constructors?(1)?

        private CONTRACT()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class FACTOR_CREDIT_LINE
    {
        #region?Fields?(3)?

        /// <summary>
        /// ����Ч
        /// </summary>
        public static readonly const string AVAILABILITY = "����Ч";
        /// <summary>
        /// �ѹ���
        /// </summary>
        public static readonly const string EXPIRY = "�ѹ���";
        /// <summary>
        /// �Ѷ���
        /// </summary>
        public static readonly const string FREEZE = "�Ѷ���";

        #endregion?Fields?

        #region?Constructors?(1)?

        private FACTOR_CREDIT_LINE()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class CASEStr
    {
        #region?Fields?(3)?

        /// <summary>
        /// ���밸
        /// </summary>
        public static readonly const string APPLICATION = "���밸";
        /// <summary>
        /// �ѽ᰸
        /// </summary>
        public static readonly const string CLOSED = "�ѽ᰸";
        /// <summary>
        /// ������
        /// </summary>
        public static readonly const string ENABLE = "������";

        #endregion?Fields?

        #region?Constructors?(1)?

        private CASEStr()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class CDAStr
    {
        #region?Fields?(4)?

        /// <summary>
        /// �Ѹ���
        /// </summary>
        public static readonly const string CHECKED = "�����";
        /// <summary>
        /// ��ʧЧ
        /// </summary>
        public static readonly const string INVALID = "��ʧЧ";
        /// <summary>
        /// ����δͨ��
        /// </summary>
        public static readonly const string REJECT = "���δͨ��";
        /// <summary>
        /// δ���
        /// </summary>
        public static readonly const string UNCHECK = "δ���";

        #endregion?Fields?

        #region?Constructors?(1)?

        private CDAStr()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class BATCH
    {
        #region?Fields?(3)?

        /// <summary>
        /// �Ѹ���
        /// </summary>
        public static readonly const string CHECK = "�Ѹ���";
        /// <summary>
        /// ����δͨ��
        /// </summary>
        public static readonly const string REJECT = "����δͨ��";
        /// <summary>
        /// δ����
        /// </summary>
        public static readonly const string UNCHECK = "δ����";

        #endregion?Fields?

        #region?Constructors?(1)?

        private BATCH()
        {
        }

        #endregion?Constructors?
    }

    /// <summary>
    /// 
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// ��ֱ�Ӹ���
        /// </summary>
        public static readonly const string BUYER_PAYMENT = "��ֱ�Ӹ���";
        
        /// <summary>
        /// �򷽼�Ӹ���
        /// </summary>
        public static readonly const string INDIRECT_PAYMENT = "�򷽼�Ӹ���";

        /// <summary>
        /// ��������
        /// </summary>
        public static readonly const string GUARANTEE_PAYMENT = "��������";

        /// <summary>
        /// ��ת��
        /// </summary>
        public static readonly const string SELLER_REASSIGN = "��ת��";

        /// <summary>
        /// ����֪ͨ
        /// </summary>
        public static readonly const string CREDIT_NOTE_PAYMENT = "����֪ͨ";

        private Payment()
        {
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Refund
    {
        private Refund()
        {
        }

        /// <summary>
        /// ��ֱ�Ӹ���
        /// </summary>
        public static readonly const string BUYER_PAYMENT = "��ֱ�Ӹ���";

        /// <summary>
        /// ��������
        /// </summary>
        public static readonly const string SELLER_REFUND = "��������";
    }

    /// <summary>
    /// 
    /// </summary>
    public class Finance
    {
        private Finance()
        {
        }

        /// <summary>
        /// ����Ԥ����(����)
        /// </summary>
        public static readonly const string FINANCE_TYPE1 = "����Ԥ����(����)";

        /// <summary>
        /// ��������
        /// </summary>
        public static readonly const string FINANCE_TYPE2 = "��������";

        /// <summary>
        /// �򷽴���
        /// </summary>
        public static readonly const string FINANCE_TYPE3 = "�򷽴���";
        
        /// <summary>
        /// ���гжһ�Ʊ
        /// </summary>
        public static readonly const string FINANCE_TYPE4 = "���гжһ�Ʊ";

        /// <summary>
        /// ��ҵ�жһ�Ʊ
        /// </summary>
        public static readonly const string FINANCE_TYPE5 = "��ҵ�жһ�Ʊ";

        /// <summary>
        /// ��������֤
        /// </summary>
        public static readonly const string FINANCE_TYPE6 = "��������֤";

        /// <summary>
        /// ��������֤
        /// </summary>
        public static readonly const string FINANCE_TYPE7 = "��������֤";

        /// <summary>
        /// ����
        /// </summary>
        public static readonly const string FINANCE_TYPE8 = "����";

        /// <summary>
        /// δ֪
        /// </summary>
        public static readonly const string FINANCE_TYPE9 = "δ֪";
    }
}
