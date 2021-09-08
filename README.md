## Documentation

_[Link to Documentation](https://ricardo17coelho.github.io/order-management/)_


## Metrics

[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=ricardo17coelho_order-management&metric=ncloc)](https://sonarcloud.io/dashboard?id=ricardo17coelho_order-management)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=ricardo17coelho_order-management&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=ricardo17coelho_order-management)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=ricardo17coelho_order-management&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=ricardo17coelho_order-management)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=ricardo17coelho_order-management&metric=security_rating)](https://sonarcloud.io/dashboard?id=ricardo17coelho_order-management)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=ricardo17coelho_order-management&metric=bugs)](https://sonarcloud.io/dashboard?id=ricardo17coelho_order-management)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=ricardo17coelho_order-management&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=ricardo17coelho_order-management)

_[Link to Sonar](https://sonarcloud.io/dashboard?id=ricardo17coelho_order-management)_


### Coverage
Unfortunately Code Coverage doesn't work on Sonar for this project.

Command to execute Tests and generate a report.xml:
```
dotnet test --no-build --collect:"XPlat Code Coverage" --verbosity normal ./code -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Format=opencover
```

Command to generate a viewable html:
```
reportgenerator.exe -reports:"code/order-management.tests/TestResults/GENERATED_ID/coverage.opencover.xml" -targetdir:"CodeCoverageReport" -reporttypes:HtmlSummary
```
_[Link to Code Coverage](https://htmlpreview.github.io/?https://github.com/ricardo17coelho/order-management/blob/main/CodeCoverageReport/summary.html)_