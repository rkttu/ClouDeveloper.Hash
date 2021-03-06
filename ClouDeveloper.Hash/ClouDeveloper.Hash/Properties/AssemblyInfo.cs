﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 어셈블리의 일반 정보는 다음 특성 집합을 통해 제어됩니다.
// 어셈블리와 관련된 정보를 수정하려면
// 이 특성 값을 변경하십시오.
[assembly: AssemblyTitle("ClouDeveloper Hash Extension Library")]
[assembly: AssemblyDescription("This component provides hash extension methods.")]

#if DEBUG
[assembly: AssemblyConfiguration("DEBUG")]
#else // DEBUG
[assembly: AssemblyConfiguration("RELEASE")]
#endif // DEBUG

[assembly: AssemblyCompany("ClouDeveloper")]
[assembly: AssemblyProduct("ClouDeveloper")]
[assembly: AssemblyCopyright("Copyright (c) 2015 ClouDeveloper, All rights reserved.")]
[assembly: AssemblyTrademark("ClouDeveloper")]
[assembly: AssemblyCulture("")]

// ComVisible을 false로 설정하면 이 어셈블리의 형식이 COM 구성 요소에 
// 표시되지 않습니다. COM에서 이 어셈블리의 형식에 액세스하려면 
// 해당 형식에 대해 ComVisible 특성을 true로 설정하십시오.
[assembly: ComVisible(false)]

// 이 프로젝트가 COM에 노출되는 경우 다음 GUID는 typelib의 ID를 나타냅니다.
[assembly: Guid("706b0ec5-db6f-47fc-b1f2-a8149e0c8437")]

// 어셈블리의 버전 정보는 다음 네 가지 값으로 구성됩니다.
//
//      주 버전
//      부 버전 
//      빌드 번호
//      수정 버전
//
// 모든 값을 지정하거나 아래와 같이 '*'를 사용하여 빌드 번호 및 수정 버전이 자동으로
// 지정되도록 할 수 있습니다.
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
