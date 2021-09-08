# Applikation Inbetriebnahme

## Download

Der Sourcecode von order-management wird mit Git verwaltet. Als Plattform wird www.github.com verwendet. Um den Sourcecode herunter zu laden kann entweder dieser Command ausgeführt werden:

```bash
git clone https://github.com/ricardo17coelho/order-management.git
```

Oder er kann von folgender URL manuell als .zip heruntergeladen werden:

```bash
https://github.com/ricardo17coelho/order-management
```

## Datenbank

Order-Management braucht zwingend eine laufende MSSQL-Datenbank, die auf dem gleichen Host läuft, wie die Applikation.

Der angemeldete Windows-User muss sich zwingend mit dieser Datenbank verbinden dürfen.

```
(Trusted_Connection=True)
```

Bevor man die Applikation startet, muss man die Datenbank vorbereiten. Dafür sollte das Visual Studio Projekt geöffnet werden und in der Package Manager Console folgender Command ausgeführt werden:

```bash
Update-Database
```

Dies generiert die nötigen Tabellen mit allen dazugehörigen Spalten und Beziehungen.

## Testdaten

Dieser Command generiert nicht nur sämtliche Tabellen, sondern auch einige Testdaten, damit order-management dann auch getestet werden kann. Dies wurde in der Methode onModelCreating() im DbContext implementiert.
