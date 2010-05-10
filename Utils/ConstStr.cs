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
        public static readonly string DATA_UPDATE_SUCCESS = "���ݸ��³ɹ�";
        public static readonly string MAIN_DEFAULT = "��ӭʹ���й��������б�����Ӫϵͳ";
        /// <summary>
        /// ��ʾ
        /// </summary>
        public static readonly string TITLE_INFORMATION = "��ʾ";
        /// <summary>
        /// ����
        /// </summary>
        public static readonly string TITLE_WARNING = "����";

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
        public static readonly string AVAILABILITY = "����Ч";
        /// <summary>
        /// �ѹ���
        /// </summary>
        public static readonly string EXPIRY = "�ѹ���";
        /// <summary>
        /// �Ѷ���
        /// </summary>
        public static readonly string FREEZE = "�Ѷ���";

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
        public static readonly string AVAILABILITY = "����Ч";
        /// <summary>
        /// �ѹ���
        /// </summary>
        public static readonly string EXPIRY = "�ѹ���";

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
        public static readonly string AVAILABILITY = "����Ч";
        /// <summary>
        /// �ѹ���
        /// </summary>
        public static readonly string EXPIRY = "�ѹ���";
        /// <summary>
        /// �Ѷ���
        /// </summary>
        public static readonly string FREEZE = "�Ѷ���";

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
        public static readonly string APPLICATION = "���밸";
        /// <summary>
        /// �ѽ᰸
        /// </summary>
        public static readonly string CLOSED = "�ѽ᰸";
        /// <summary>
        /// ������
        /// </summary>
        public static readonly string ENABLE = "������";

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
        public static readonly string CHECKED = "�����";
        /// <summary>
        /// ��ʧЧ
        /// </summary>
        public static readonly string INVALID = "��ʧЧ";
        /// <summary>
        /// ����δͨ��
        /// </summary>
        public static readonly string REJECT = "���δͨ��";
        /// <summary>
        /// δ���
        /// </summary>
        public static readonly string UNCHECK = "δ���";

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
        public static readonly string CHECK = "�Ѹ���";
        /// <summary>
        /// ����δͨ��
        /// </summary>
        public static readonly string REJECT = "����δͨ��";
        /// <summary>
        /// δ����
        /// </summary>
        public static readonly string UNCHECK = "δ����";

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
        public static readonly string BUYER_PAYMENT = "��ֱ�Ӹ���";
        
        /// <summary>
        /// �򷽼�Ӹ���
        /// </summary>
        public static readonly string INDIRECT_PAYMENT = "�򷽼�Ӹ���";

        /// <summary>
        /// ��������
        /// </summary>
        public static readonly string GUARANTEE_PAYMENT = "��������";

        /// <summary>
        /// ��ת��
        /// </summary>
        public static readonly string SELLER_REASSIGN = "��ת��";

        /// <summary>
        /// ����֪ͨ
        /// </summary>
        public static readonly string CREDIT_NOTE_PAYMENT = "����֪ͨ";

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
        public static readonly string BUYER_PAYMENT = "��ֱ�Ӹ���";

        /// <summary>
        /// ��������
        /// </summary>
        public static readonly string SELLER_REFUND = "��������";
    }
}
