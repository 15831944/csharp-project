using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace DzhSample
{
    public enum DATA_TYPE
    {
        TICK_DATA = 2,				//�ֱʳɽ�
        MIN1_DATA,					//1������
        MIN5_DATA,					//5������					
        MIN15_DATA,					//15������
        MIN30_DATA,					//30������
        MIN60_DATA,					//60������
        DAY_DATA,					//����
        WEEK_DATA,					//����
        MONTH_DATA,					//����
        MULTI_DATA					//������
    }

    ///////////////////////////////////////////////////////////////////////////
    //��������

    public struct STKDATA
    {
        public Int32 m_time;
        //time_t	m_time;			//ʱ��,UCT
        public float m_fOpen;		//����
        public float m_fHigh;		//���
        public float m_fLow;			//���
        public float m_fClose;		//����
        public float m_fVolume;		//�ɽ���
        public float m_fAmount;		//�ɽ���
        public UInt16 m_wAdvance;		//���Ǽ���(��������Ч)
        public UInt16 m_wDecline;		//�µ�����(��������Ч)
    }


    ////////////////////////////////////////////////////////////////////////////
    //��չ����,���������ֱʳɽ����ݵ�������
    /*
    typedef union tagSTKDATAEx
    {
        struct
        {
            float m_fBuyPrice[3];		//��1--��3��
            float m_fBuyVol[3];			//��1--��3��
            float m_fSellPrice[3];		//��1--��3��	
            float m_fSellVol[3];		//��1--��3��
        };
        float m_fDataEx[12];			//����
    } STKDATAEx;
    */
    /*
    public struct STKDATAEx
    {
        //���ǻ۵���������ǲ��Ե�.
        public float m_fBuyPrice1;		//��1--��3��
        public float m_fBuyPrice2;		//��1--��3��
        public float m_fBuyPrice3;		//��1--��3��
        public float m_fBuyVol1;	    //��1--��3��
        public float m_fBuyVol2;		//��1--��3��
        public float m_fBuyVol3;		//��1--��3��
        public float m_fSellVol2;		//��1--��3��
        public float m_fSellVol3;		//��1--��3��
        public float m_fSellPrice3;		//��1--��3��	
        public float m_fSellVol1;		//��1--��3��
        public float m_fSellPrice1;		//��1--��3��	
        public float m_fSellPrice2;		//��1--��3��	
    }
     * */
    public struct STKDATAEx
    {
        //���ǻ۵���������ǲ��Ե�.
        public float m_fBuyPrice1;
        public float m_fBuyPrice2;
        public float m_fBuyPrice3;
        public float m_fBuyPrice4;
        public float m_fBuyPrice5;
        public float m_fBuyVol1;
        public float m_fBuyVol2;
        public float m_fBuyVol3;
        public float m_fBuyVol4;
        public float m_fBuyVol5;
        public float m_fSellPrice1;
        public float m_fSellPrice2;
        public float m_fSellPrice3;
        public float m_fSellPrice4;
        public float m_fSellPrice5;
        public float m_fSellVol1;
        public float m_fSellVol2;
        public float m_fSellVol3;
        public float m_fSellVol4;
        public float m_fSellVol5;
    }
    /////////////////////////////////////////////////////////////////////////////
    /*��������˳��(m_pfFinData����)

        ���	����

        0	�ܹɱ�(���),
        1	���ҹ�,
        2	�����˷��˹�,
        3	���˹�,
        4	B��,
        5	H��,
        6	��ͨA��,
        7	ְ����,
        8	A2ת���,
        9	���ʲ�(ǧԪ),
        10	�����ʲ�,
        11	�̶��ʲ�,
        12	�����ʲ�,
        13	����Ͷ��,
        14	������ծ,
        15	���ڸ�ծ,
        16	�ʱ�������,
        17	ÿ�ɹ�����,
        18	�ɶ�Ȩ��,
        19	��Ӫ����,
        20	��Ӫ����,
        21	��������,
        22	Ӫҵ����,
        23	Ͷ������,
        24	��������,
        25	Ӫҵ����֧,
        26	�����������,
        27	�����ܶ�,
        28	˰������,
        29	������,
        30	δ��������,
        31	ÿ��δ����,
        32	ÿ������,
        33	ÿ�ɾ��ʲ�,
        34	����ÿ�ɾ���,
        35	�ɶ�Ȩ���,
        36	����������
    */

    /////////////////////////////////////////////////////////////////////////////
    //�������ݽṹ

    public struct CALCINFO_SHARP
    {
        public UInt32 m_dwSize;				//�ṹ��С
        public UInt32 m_dwVersion;			//��������汾(V2.10 : 0x210)
        public UInt32 m_dwSerial;				//����������к�
        public Int32 m_strStkLabel;			//��Ʊ����
        public Int32 m_bIndex;				//����

        public Int32 m_nNumData;				//��������(pData,pDataEx,pResultBuf��������)
        public Int32 m_pData;				//��������,ע��:��m_nNumData==0ʱ����Ϊ NULL
        public Int32 m_pDataEx;				//��չ����,�ֱʳɽ�������,ע��:����Ϊ NULL

        public Int32 m_nParam1Start;			//����1��Чλ��
        public Int32 m_pfParam1;				//���ò���1	
        public Int32 m_pfParam2;				//���ò���2
        public Int32 m_pfParam3;				//���ò���3
        public Int32 m_pfParam4;				//���ò���3

        public Int32 m_pResultBuf;			//���������
        public Int32 m_dataType;				//��������
        public Int32 m_pfFinData;			//��������
    }
    /* 
    ע: 
        1.�������ò�����m_pfParam1--m_pfParam4����,��ΪNULL���ʾ�ò�����Ч.
        2.��һ��������Чʱ,���������в�������Ч.
            ��:m_pfParam2ΪNULL,��m_pfParam3,m_pfParam4һ��ΪNULL.
        3.����1�����ǳ�������������������,�������ֻ��Ϊ��������.
        4.��m_nParam1Start<0, �����1Ϊ��������,��������*m_pfParam1;
        5.��m_nParam1Start>=0,�����1Ϊ����������,m_pfParam1ָ��һ������������,
            �����СΪm_nNumData,������Ч��ΧΪm_nParam1Start--m_nNumData.
            ��ʱ����m_pData[x] �� m_pfParam1[x]��һ�µ�
    */


    ///////////////////////////////////////////////////////////////////////////////////
    /* �������

    __declspec(dllexport) int xxxxxxxx(CALCINFO* pData);	---------- A
    __declspec(dllexport) int xxxxxxxxVAR(CALCINDO* pData);	---------- B

    1.����������ȫ����д.
    2.��������������A,B������ʽ֮һ����,����ʵ�ʺ����������xxxxxxxx;
        ����C++����������� extern "C" {   } ������.
    3.������ʽA������������������ȫ������Ϊ�����ĺ���;
        ��ʽB������������1Ϊ�������ĺ���;���ֺ������������ں�����VAR��β.
    4.������������pData->m_pResultBuf����.
    5.��������-1��ʾ�����ȫ��������Ч,���򷵻ص�һ����Чֵλ��,��:
        m_pResultBuf[����ֵ] -- m_pResultBuf[m_nNumData-1]��Ϊ��Чֵ.
    6.�������Ƴ��Ȳ��ܳ���15�ֽ�,��̬���ӿ��ļ������ܳ���9�ֽ�(��������չ��),��̬�����Ʋ��ܽ�SYSTEM,EXPLORER
    7.����ʱ����ѡ��1�ֽڶ���

    */

}