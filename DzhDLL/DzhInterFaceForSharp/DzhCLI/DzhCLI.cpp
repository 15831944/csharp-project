// DzhCLI.cpp : ���� DLL Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include "DzhCLI.h"
using namespace DzhSample;

#ifdef _MANAGED
#pragma managed(push, off)
#endif

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
					 )
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
    return TRUE;
}

#ifdef _MANAGED
#pragma managed(pop)
#endif
//��һ��C# DLL(DzhSample.DLL)����ʲô�������,�����ԭ�����һ��
//����ʹ��ͬ������
//�����������,�ǵ���DzhCLI.h����Ӷ���,��:__declspec(dllexport) int WINAPI SHOWFORMVAR(CALCINFO* pData);
////////////
//����ƽ��ֵ.
//���ǻ۹�ʽ�﷨:p1:= "DzhCLI @ AVERAGEVAR"(5);//5��ƽ��
__declspec(dllexport) int WINAPI AVERAGEVAR(CALCINFO* pData)
{
	CDzhSample pDzhSample;
	int nResult = pDzhSample.AVERAGEVAR((int)(LONG_PTR)pData);
	return nResult;
}
////////////
//����ƽ��ֵ��.
//���ǻ۹�ʽ�﷨:p1:= "DzhCLI @ AVERAGEDIFFVAR"(5,12);//5��ƽ�� - 12��ƽ��
__declspec(dllexport) int WINAPI AVERAGEDIFFVAR(CALCINFO* pData)
{
	CDzhSample pDzhSample;
	int nResult = pDzhSample.AVERAGEDIFFVAR((int)(LONG_PTR)pData);
	return nResult;
}
////////////
//����MACD.
//���ǻ۹�ʽ�﷨:p1:= "DzhCLI @ MACDVAR"(12,26,9);//12��ƽ�� - 26��ƽ��,�Բ�ֵ������9��ƽ��,������
__declspec(dllexport) int WINAPI MACDVAR(CALCINFO* pData)
{
	CDzhSample pDzhSample;
	int nResult = pDzhSample.MACDVAR((int)(LONG_PTR)pData);
	return nResult;
}
////////////
//��ʾһ������.
//���ǻ۹�ʽ�﷨:p1:= "DzhCLI @ SHOWFORMVAR";
__declspec(dllexport) int WINAPI SHOWFORMVAR(CALCINFO* pData)
{
	CDzhSample pDzhSample;
	int nResult = pDzhSample.SHOWFORMVAR((int)(LONG_PTR)pData);
	return nResult;
}
