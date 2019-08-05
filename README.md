# Project REDHEAD v2

[![Build Status](https://dev.azure.com/ginomessmer/Project%20REDHEAD%20v2/_apis/build/status/redhead%20Build?branchName=master)](https://dev.azure.com/ginomessmer/Project%20REDHEAD%20v2/_build/latest?definitionId=20&branchName=master)


Project REDHEAD ist eine Neuentwicklung unserer Projektarbeit, das Studenten der DHBW Karlsruhe eine Kurswebseite mit allen nützlichen Infos anbietet. Features wie Stundenpläne, Fahrpläne, Mensapläne und Wettspiele zählen dazu.

## Genutzte Technologien und Services
- **ASP.NET Core** für die API
- **React** für das Front End
- **MongoDB** für die Datenbank
- **Docker** fürs Deployment
- **Discord** als OAuth Provider für die Anmeldung

## Einstellungen
`ProjectRedhead.Application/appsettings.json` benötigt folgende Einstellungen:

|Key|Beschreibung|Default|
|---|---|---|
|`ConnectionStrings:MongoDatabase`|Der Connection String der MongoDB Instanz|N/A|
|`Database:Name`|Der Name der Datenbank, die genutzt werden soll|`redhead`|
|`Authentication:Discord:Id`|Die Client ID von der registrierten Discord App|N/A|
|`Authentication:Discord:Secret`|Das Client Secret von der registrierten Discord App|N/A|

## Mitwirken
Wir laden jeden dazu ein mitzuwirken. Wir haben vor unsere Erfahrungen aus der ersten Projektarbeit hier einfließen zu lassen, das Projekt während unserer Freizeit zu entwickeln, um auch mit neuen Technologien zu experimentieren, und das Endprodukt bis zum Ende des Studiums dem Kurs bereitzustellen.
