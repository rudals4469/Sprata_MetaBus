<!DOCTYPE html>
<html lang="ko">
<head>
  <meta charset="UTF-8">
  <title>Sprata_MetaBus 개인 과제</title>
  <style>
    body {
      font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
      background-color: #f4f6f8;
      color: #333;
      margin: 0;
      padding: 40px;
    }

    .container {
      max-width: 800px;
      margin: auto;
      background: #fff;
      padding: 30px 40px;
      border-radius: 10px;
      box-shadow: 0 4px 12px rgba(0,0,0,0.1);
    }

    h1 {
      color: #2c3e50;
      text-align: center;
      margin-bottom: 10px;
    }

    h2 {
      text-align: center;
      font-weight: normal;
      color: #7f8c8d;
      margin-bottom: 30px;
    }

    h3 {
      color: #34495e;
      margin-top: 30px;
      border-left: 4px solid #3498db;
      padding-left: 10px;
    }

    ul {
      list-style-type: disc;
      padding-left: 20px;
    }

    li {
      margin-bottom: 8px;
    }
  </style>
</head>
<body>

  <div class="container">
    <h1>Sprata_MetaBus</h1>
    <h2>스파르타 메타버스 만들기 개인 과제</h2>

    <h3>1) 캐릭터 이동 및 맵 탐색</h3>
    <ul>
      <li>[1] WASD 또는 화살표 키를 사용해 2D 캐릭터가 맵을 자유롭게 이동하도록 구현한다.</li>
      <li>[2] 맵의 가장자리에서는 캐릭터가 멈추도록 구현한다.</li>
      <li>[3] 키보드 Z 입력 시 탄환 발사 및 오른쪽에 있는 몬스터 히트 시 애니메이션이 작동한다.</li>
    </ul>

    <h3>2) 맵 설계 및 상호작용 영역</h3>
    <ul>
      <li>[1] 간단한 맵을 설계, 특정 영역에서 상호작용 이벤트 발생한다.</li>
      <li>[2] 타일맵으로 구현하였으며, 특정 영역에 들어가면 이벤트 트리거를 사용하여 미니게임에 진입 할 수 있는 UI 팝업창 표시해준다.</li>
    </ul>

    <h3>3) 미니 게임 실행</h3>
    <ul>
      <li>[1] 위의 UI에서 Yes 버튼 클릭 시 간단한 미니 게임 실행 (11시 방향 플래피버드, 1시 방향 블록쌓기)한다.</li>
      <li>[2] 미니 게임 시작 전 UI 창에서 게임에 대한 간단한 설명 UI 표시해준다.</li>
      <li>[3] 미니 게임 종료 시 재시작 버튼과 나가기 버튼을 통해 다음 행동 선택 가능하게 한다.</li>
      <li>[4] 나가기 버튼 클릭 시 점수 반환 및 맵으로 복귀한다.</li>
    </ul>

    <h3>4) 점수 시스템</h3>
    <ul>
      <li>[1] 점수를 실시간으로 UI에 표시하고 최고 점수를 저장 및 표시해준다.</li>
      <li>[2] 미니 게임 종료 후 맵으로 돌아왔을 때 점수가 유지되도록 저장한다.</li>
    </ul>

    <h3>5) 카메라 추적 기능</h3>
    <ul>
      <li>[1] 캐릭터가 이동할 때 카메라가 자연스럽게 따라오도록 기능을 구현한다.</li>
      <li>[2] 카메라가 특정 영역을 넘어가지 않도록 경계를 설정한다.</li>
    </ul>
  </div>

</body>
</html>
