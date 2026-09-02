# Development Setup

Tiny Guardians 개발환경 설치 가이드다. 기준 환경은 Windows PC + Unreal Engine 5.8.0 + Visual Studio 2022 + VS Code다.

## 설치 순서

1. Epic Games Launcher 설치
2. Unreal Engine 5.8.0 설치
3. Visual Studio 2022 설치
4. VS Code와 Codex/Claude Code 확장 준비
5. GitHub 저장소 클론 또는 현재 로컬 저장소 사용
6. UE5 `TinyGuardians` 프로젝트 생성 및 빌드 검증

## 1. Epic Games Launcher

공식 다운로드:

- <https://www.unrealengine.com/download>

Unreal Engine은 일반적으로 Epic Games Launcher를 통해 설치한다.

## 2. Unreal Engine 5.8.0

Epic Games Launcher 설치 후:

1. Epic Games Launcher 실행
2. Unreal Engine 메뉴 선택
3. Library 탭 선택
4. Engine Versions에서 `+` 버튼 선택
5. Unreal Engine 5.8.0 설치

주의:

- Tiny Guardians의 기준 UE 버전은 `5.8.0`으로 확정했다.
- 프로젝트 생성 후에도 같은 팀/AI 작업자가 같은 UE 버전을 사용하도록 유지한다.

## 3. Visual Studio 2022

UE C++ 개발과 빌드를 위해 Visual Studio 2022 설치를 권장한다.

공식 문서:

- <https://dev.epicgames.com/documentation/unreal-engine/setting-up-visual-studio-development-environment-for-cplusplus-projects-in-unreal-engine>
- <https://learn.microsoft.com/en-us/visualstudio/gamedev/unreal/get-started/vs-tools-unreal-install>

Visual Studio Installer에서 권장 선택:

- Workload: `Game development with C++`
- Component: Visual Studio Tools for Unreal Engine
- Component: Visual Studio debugger tools for Unreal Engine Blueprints
- Component: Unreal Engine Test Adapter
- Component: Windows 10 SDK 10.0.18362.0 이상 또는 Windows 11 SDK
- Optional: HLSL Tools
- Component: `.NET Framework 4.8 SDK`
- Component: `.NET Framework 4.8 Targeting Pack`

## 4. VS Code

VS Code는 문서 작업, Git 작업, Codex/Claude Code 작업에 사용한다.

UE Editor 안에서 VS Code를 기본 소스 코드 편집기로 지정하려면:

1. Unreal Editor 실행
2. Edit > Editor Preferences
3. General > Source Code
4. Source Code Editor를 Visual Studio Code로 설정

공식 문서:

- <https://dev.epicgames.com/documentation/unreal-engine/setting-up-visual-studio-code-for-unreal-engine>

## 5. Git과 GitHub

현재 로컬 저장소:

- Windows: `E:\Projects\TinyGuardians`
- WSL: `/mnt/e/Projects/TinyGuardians`

현재 원격 저장소:

- <https://github.com/jhkwon19/TinyGuardians>

주의:

- Git LFS는 사용하지 않으며, 대형 UE 바이너리 에셋은 커밋 전에 파일 크기를 확인한다.
- `Binaries/`, `Intermediate/`, `Saved/`, `DerivedDataCache/` 등은 Git에 커밋하지 않는다.

## 6. WSL 사용 기준

프로젝트는 Windows SSD의 NTFS 경로에 두고 WSL에서 같은 경로를 마운트해 사용한다.

- 문서 작업, Git 작업, 코드 검색에는 WSL을 사용해도 된다.
- Unreal Editor 실행과 UE 프로젝트 생성은 Windows 쪽 Epic Games Launcher/Unreal Editor에서 진행하는 것을 권장한다.
- Unreal Editor와 Visual Studio는 `E:\Projects\TinyGuardians`를 사용한다.
- WSL 기반 도구는 `/mnt/e/Projects/TinyGuardians`를 사용한다.

## 다음 확인 사항

- 게임패드 2개 보유 여부와 Windows 인식 여부
