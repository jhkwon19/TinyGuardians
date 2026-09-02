# AI Changelog

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
