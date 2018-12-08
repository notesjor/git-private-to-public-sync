# git-private-to-public-sync
Der Name dieses Programms ist so umständlich wie die Funktion - wobei die Lösung eigentlich einfach sein sollte.
Am Anfang stand der Wunsch teile eines privaten GIT-Repositories in ein öffentliches GIT-Repository zu verschieben.
Hierfür gibt es einige Lösungen, aber wie gesagt, keine einfachen.

Startet man das Programm, muss man zunächst das private GIT-Repository wählen, danach das öffentliche GIT-Repository.
Wurden die beiden GIT-Repositorien bereits einmal synchronisiert, dann werden automatisch die identischen Dateien/Ornder ausgewählt.
Andernfalls (oder falls man etwas hinzufügen möchte) muss man selbst eine Auswahl treffen. Danach kann man die Synchronisation starten.

Neu in Version 2018-12
- Man kann jetzt die Dateien während der Synchronisation zwischen zwei GIT-Repositorien mittels AES verschlüsseln.