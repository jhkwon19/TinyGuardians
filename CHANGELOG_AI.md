# AI Changelog

## 2026-09-02 15:40 UTC+9

- Agent: Codex
- 요청: Git LFS를 사용하지 않고 일반 Git으로 프로젝트 관리
- 완료:
  - Git LFS 미사용 결정을 문서화
  - 대형 UE 에셋 추가 전 단일 파일 크기와 저장소 증가량을 확인하는 운영 기준 기록
- 검증:
  - 현재 Git 대상 약 137MB, 최대 단일 파일 약 21MB
- 다음 작업:
  - UE 프로젝트 변경사항을 일반 Git으로 커밋하고 푸시한다

## 2026-09-02 15:30 UTC+9

- Agent: Codex
- 요청: UE 5.8 설치 후 C++ 프로젝트 생성과 Git 저장소 통합
- 완료:
  - `.NET Framework 4.8 SDK`와 Targeting Pack 누락 원인을 확인하고 설치 안내
  - Third Person C++ 템플릿 생성 및 첫 플레이 확인
  - 프로젝트를 `E:\Projects\TinyGuardians` 저장소 루트로 통합
  - UE 생성 캐시와 사용자별 설정을 `.gitignore`에서 제외
  - 새 저장소 경로에서 `TinyGuardiansEditor Win64 Development` 빌드 성공
- 검증:
  - 사용자가 템플릿 캐릭터 이동을 직접 확인
  - Unreal Build Tool 결과 `Succeeded`, 48개 작업 컴파일 및 링크 완료
- 현재 상태:
  - UE5 C++ 프로토타입 개발을 시작할 수 있는 기준 프로젝트가 준비됨
- 다음 작업:
  - 게임패드 2개 Windows 인식과 로컬 플레이어 생성을 검증한다

## 2026-09-02 14:15 UTC+9

- Agent: Codex
- 요청: 개발 PC 사양을 직접 확인
- 완료:
  - Windows/WSL 명령으로 CPU, RAM, GPU, VRAM, 저장공간, OS 버전 확인
  - `Docs/dev-pc-spec.md`에 개발 PC 사양 기록
  - `TODO.md`, `README.md`, `PROJECT_HANDOFF.md` 갱신
- 변경 파일:
  - `Docs/dev-pc-spec.md`: 개발 PC 사양 기록 추가
  - `TODO.md`: PC 사양 확인 완료 처리
  - `README.md`: 개발 PC 사양 문서 링크 추가
  - `PROJECT_HANDOFF.md`: 문서 링크와 다음 작업 갱신
  - `CHANGELOG_AI.md`: 작업 기록 추가
- 검증:
  - `lscpu`, `free -h`, `df -h` 실행
  - PowerShell `Get-CimInstance`로 Windows CPU/GPU/OS 정보 확인
  - `nvidia-smi`로 RTX 4070 Ti VRAM 12282 MiB 확인
- 현재 상태:
  - 개발 PC는 Tiny Guardians UE5.8 개발에 충분한 사양으로 판단
- 알려진 문제:
  - 게임패드 2개 Windows 인식 여부는 아직 미확인
- 다음 작업:
  - UE 5.8.0 설치 완료 후 Visual Studio 2022 C++ 개발환경과 게임패드 인식을 확인한다

## 2026-09-02 14:05 UTC+9

- Agent: Codex
- 요청: Epic Games Launcher에서 Unreal Engine 5.8.0 설치를 시작한 상태 공유
- 완료:
  - 프로젝트 기준 UE 버전을 `5.8.0`으로 문서에 확정 반영
  - UE 설치 상태를 설치 진행 중으로 기록
  - `README.md`, `TODO.md`, `PROJECT_HANDOFF.md`, `Docs/setup.md`, `Docs/decisions.md` 갱신
- 변경 파일:
  - `README.md`: UE 5.8.0 확정 및 설치 진행 중 표시
  - `TODO.md`: UE 5.8.0 설치 완료 대기 작업으로 갱신
  - `PROJECT_HANDOFF.md`: 현재 확정 엔진과 다음 작업 수정
  - `Docs/setup.md`: 설치 기준 버전을 UE 5.8.0으로 고정
  - `Docs/decisions.md`: UE 5.8.0 사용 확정 기록
  - `CHANGELOG_AI.md`: 작업 기록 추가
- 검증:
  - 사용자가 Epic Games Launcher에서 UE 5.8.0 설치 진행 중임을 화면/대화로 확인
- 현재 상태:
  - UE 5.8.0 설치 진행 중
- 알려진 문제:
  - Visual Studio 2022 C++ 개발환경 설치 여부는 아직 미확인
- 다음 작업:
  - UE 5.8.0 설치 완료 후 Visual Studio 2022 C++ 개발환경을 확인한다

## 2026-09-02 13:55 UTC+9

- Agent: Codex
- 요청: UE5 프로젝트 생성 전 Unreal Engine 5 설치 위치와 개발환경 구성 가이드 제공
- 완료:
  - 공식 Unreal Engine 다운로드/설치 문서와 Visual Studio 개발환경 문서를 확인
  - `Docs/setup.md` 개발환경 설치 가이드 추가
  - `README.md`, `TODO.md`, `PROJECT_HANDOFF.md`에 setup 문서와 설치 작업 반영
- 변경 파일:
  - `Docs/setup.md`: Epic Games Launcher, UE5, Visual Studio 2022, VS Code, Git, WSL 사용 기준 정리
  - `README.md`: setup 문서 링크 추가
  - `TODO.md`: UE5/Visual Studio 설치 작업 추가
  - `PROJECT_HANDOFF.md`: 설치 상태 미정 항목과 다음 작업 갱신
  - `CHANGELOG_AI.md`: 작업 기록 추가
- 검증:
  - 공식 문서 확인
  - 로컬 환경에서 UE 실행 파일 미설치 확인
- 현재 상태:
  - 로컬 Git 저장소와 GitHub 원격은 구성됨
  - UE5는 아직 설치 전
- 알려진 문제:
  - 현재 작업 경로가 WSL2 Linux 경로이므로 UE Editor는 Windows 쪽 설치/실행 기준으로 진행하는 것을 권장
- 다음 작업:
  - Windows에서 Epic Games Launcher와 Unreal Engine 5를 설치한다
  - Visual Studio 2022의 Game development with C++ workload를 설치한다

## 2026-09-02 13:45 UTC+9

- Agent: Codex
- 요청: Git 저장소를 먼저 초기화하고, 사용자가 GitHub에 동일명 repo를 생성할 예정
- 완료:
  - 로컬 Git 저장소 초기화
  - UE5 프로젝트용 `.gitignore` 생성
  - `TODO.md`에 Git 초기화 완료와 GitHub 원격 연결 대기 상태 반영
- 변경 파일:
  - `.gitignore`: Unreal Engine 생성 파일, IDE 로컬 상태, 빌드 산출물, 로그 제외 규칙 추가
  - `TODO.md`: Git 초기화 관련 작업 상태 갱신
  - `CHANGELOG_AI.md`: 작업 기록 추가
- 검증:
  - `git status --short`로 추적 전 파일 목록 확인
  - `git branch --show-current` 결과 `main` 확인
  - `git remote -v` 결과 원격 저장소 미연결 확인
- 현재 상태:
  - 로컬 Git 저장소는 생성됨
  - GitHub 원격 저장소는 아직 연결 전
- 알려진 문제:
  - 아직 첫 커밋은 만들지 않음
  - 아직 UE5 프로젝트는 생성 전
- 다음 작업:
  - 사용자가 GitHub에 `TinyGuardians` repo를 생성한 뒤 원격 URL을 연결한다
  - 원격 연결 후 문서와 `.gitignore`를 첫 커밋으로 저장한다

## 2026-09-02 13:40 UTC+9

- Agent: Codex
- 요청: `PROJECT_HANDOFF.md`에 모여 있던 기획 내용을 역할별 문서로 분리
- 완료:
  - `README.md`, `TODO.md`, `CHANGELOG_AI.md`, `Docs/game-design.md`, `Docs/gameplay-systems.md`, `Docs/decisions.md` 생성
  - `PROJECT_HANDOFF.md`를 AI 인수인계 요약 문서로 재정리
  - Tiny Guardians의 현재 확정 방향과 다음 작업을 문서별로 분리
- 변경 파일:
  - `README.md`: 프로젝트 소개와 문서 링크
  - `TODO.md`: 현재/다음/이후/완료 작업 목록
  - `CHANGELOG_AI.md`: AI 작업 기록 시작
  - `Docs/game-design.md`: 게임 기획 상세
  - `Docs/gameplay-systems.md`: 게임플레이 시스템 설계 초안
  - `Docs/decisions.md`: 주요 결정 기록
  - `PROJECT_HANDOFF.md`: 요약 인수인계 문서로 정리
- 검증:
  - 문서 파일 생성 및 주요 제목 확인
- 현재 상태:
  - UE5 프로젝트 생성 전 문서화 단계
- 알려진 문제:
  - 아직 Git 저장소가 아님
  - 정확한 UE5 버전 미정
  - 실제 빌드/플레이 검증 전
- 다음 작업:
  - 전방 캐릭터와 서포터 캐릭터의 기본 스킬 구성을 정한다
  - PC 사양과 설치 가능한 UE5 버전을 확인한다
