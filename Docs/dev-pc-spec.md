# Development PC Spec

2026-09-02 기준 개발 PC에서 확인한 사양이다.

## 요약

- OS: Microsoft Windows 11 Pro 64-bit
- Windows Version: 10.0.26200
- CPU: AMD Ryzen 5 7600 6-Core Processor
- CPU Core/Thread: 6 cores / 12 threads
- RAM: 약 32GB
- GPU: NVIDIA GeForce RTX 4070 Ti
- VRAM: 12282 MiB
- NVIDIA Driver: 581.15
- 보조 GPU: AMD Radeon(TM) Graphics

## 저장공간

- C: 약 465GB total / 약 347GB free
- D: 약 932GB total / 약 631GB free
- WSL 루트: 약 1007GB total / 약 937GB free

## 판단

Tiny Guardians의 UE5.8 개발 PC로 충분한 사양이다.

주의:

- Unreal Editor는 Windows 앱이므로 가능하면 UE 프로젝트 본체는 Windows 파일시스템에 두는 것을 우선 검토한다.
- 현재 Git 저장소와 UE5 프로젝트는 Windows SSD 경로 `E:\Projects\TinyGuardians`에 둔다.
- WSL에서는 같은 저장소를 `/mnt/e/Projects/TinyGuardians`로 접근한다.
- 에셋과 빌드 산출물이 커질 수 있으므로 D 드라이브 사용을 고려할 수 있다.
