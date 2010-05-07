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
        public static string DATA_UPDATE_SUCCESS = "���ݸ��³ɹ�";
        public static string MAIN_DEFAULT = "��ӭʹ���й��������б�����Ӫϵͳ";
        /// <summary>
        /// ��ʾ
        /// </summary>
        public static string TITLE_INFORMATION = "��ʾ";
        /// <summary>
        /// ����
        /// </summary>
        public static string TITLE_WARNING = "����";

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
        public static string AVAILABILITY = "����Ч";
        /// <summary>
        /// �ѹ���
        /// </summary>
        public static string EXPIRY = "�ѹ���";
        /// <summary>
        /// �Ѷ���
        /// </summary>
        public static string FREEZE = "�Ѷ���";

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
        public static string AVAILABILITY = "����Ч";
        /// <summary>
        /// �ѹ���
        /// </summary>
        public static string EXPIRY = "�ѹ���";

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
        public static string AVAILABILITY = "����Ч";
        /// <summary>
        /// �ѹ���
        /// </summary>
        public static string EXPIRY = "�ѹ���";
        /// <summary>
        /// �Ѷ���
        /// </summary>
        public static string FREEZE = "�Ѷ���";

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
        public static string APPLICATION = "���밸";
        /// <summary>
        /// �ѽ᰸
        /// </summary>
        public static string CLOSED = "�ѽ᰸";
        /// <summary>
        /// ������
        /// </summary>
        public static string ENABLE = "������";

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
        public static string CHECKED = "�����";
        /// <summary>
        /// ��ʧЧ
        /// </summary>
        public static string INVALID = "��ʧЧ";
        /// <summary>
        /// ����δͨ��
        /// </summary>
        public static string REJECT = "���δͨ��";
        /// <summary>
        /// δ���
        /// </summary>
        public static string UNCHECK = "δ���";

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
        public static string CHECK = "�Ѹ���";
        /// <summary>
        /// ����δͨ��
        /// </summary>
        public static string REJECT = "����δͨ��";
        /// <summary>
        /// δ����
        /// </summary>
        public static string UNCHECK = "δ����";

		#endregion?Fields?

		#region?Constructors?(1)?

        private BATCH()
        {
        }

		#endregion?Constructors?
    }
}
