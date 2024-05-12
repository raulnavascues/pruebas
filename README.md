# Pruebas de Coberura de código
Pruebas varias de código

Para ejecutar las pruebas y generar los informes de cobertura seguir las instrucciones de esta pagina https://learn.microsoft.com/es-es/dotnet/core/testing/unit-testing-code-coverage?tabs=windows

Si se tiene el proyecto de test ya configurado, hay que instalar el plugin ReportGenerator
dotnet tool install --global dotnet-reportgenerator-globaltool --version 5.2.5

Para generar el informe HTML hay que lanzar en un Powershell la siguiente innstrucción
reportgenerator -reports:"D:\NET Developing\MiWeb\TestUnitarios\TestResults\07e4df70-30e6-4053-ab8a-dd5c393fe6cf\coverage.cobertura.xml" -targetdir:"coveragereport2" -reporttypes:Html
