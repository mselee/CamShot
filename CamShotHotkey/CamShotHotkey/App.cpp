#include <Windows.h>
#include "LimitSingleInstance.h"
using namespace std;

CLimitSingleInstance g_SingleInstanceObj(L"Global\\{C62C6AFD-C4A6-4D24-B0D2-0963AC635182}");

void TakeScreenShot() {
	STARTUPINFO info={sizeof(info)};
	PROCESS_INFORMATION processInfo;
	if (CreateProcess(L"..\\Debug\\CamShot.exe", NULL, NULL, NULL, TRUE, 0, NULL, NULL, &info, &processInfo))
	{
		CloseHandle(processInfo.hProcess);
		CloseHandle(processInfo.hThread);
	}
}

LRESULT CALLBACK HandleHotkey(int nCode, WPARAM wParam, LPARAM lParam) {
	PKBDLLHOOKSTRUCT p = (PKBDLLHOOKSTRUCT) (lParam);
	
	if (wParam == WM_KEYUP && p->vkCode == VK_SNAPSHOT) {
		TakeScreenShot();
	}
	return CallNextHookEx(NULL, nCode, wParam, lParam);
}

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow) {
	if (g_SingleInstanceObj.IsAnotherInstanceRunning()) return FALSE;
	HHOOK keyboardHook = SetWindowsHookEx(
		WH_KEYBOARD_LL,
		HandleHotkey,
		NULL,
		0);
	MSG message;
	while(GetMessage(&message, NULL, 0, 0))
	{
		TranslateMessage(&message);
		DispatchMessage(&message);
	}
	UnhookWindowsHookEx(keyboardHook);
	return 0;
}