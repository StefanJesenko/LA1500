# Projekt-Dokumentation

Poppy Jesenko, Oesch, Spycher und Veljkovic

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|21.02.2023| 0.0.1|Wir haben uns heute zuerst etwas in der Gruppe kennengelernt, in einer zweiten Phase haben wir uns entschieden, dass wir ein 2D Jump & Run Spiel machen wollen.|
| 28.02.2023      | 0.2.2     |   Wir haben die User Storys, Testfälle und Planen fertiggestellt und haben schon mit dem Realisieren begonnen.    |
| 07.03.2023      | 0.5.3     |   Wir haben die ersten Level designt, der Spieler hat jetzt eine Health Bar und wir hatten am Anfang viel Probleme beim Sharen des Projekts. |
| 14.03.2023      | 0.0.0     |   . |
| 21.03.2023      | 0.0.0     |   . |
| 28.03.2023      | 0.0.0     |   . |
| 04.04.2023      | 0.0.0     |   . |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Wir machen ein 2D Jump & Run in Unity.

 
Wir haben vor ein 2D Jump & Run in Unity zu machen, wir haben uns gedacht, dass wir zuerst ein kleines 2D spiel, machen, indem ein Spieler von Plattform zu Plattform springen kann, wenn wir das geschafft haben, ist unser Ziel das wir ein 2D Jump & Run machen mit mehreren Leveln indem es Gegner gibt, die der Spieler auch bekämpfen kann. Unser Ziel ist es dabei zu lernen, wie man ein Spiel in Unity programmiert.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |Muss             |Funktional|Als User möchte ich, dass wenn ich das Spiel starte, dass ich dann in einem Level bin und mich bewegen kann, damit ich das Spiel spielen kann.|
| 2    |Muss             |Funktional|Als User möchte ich, dass mein Charakter springen kann, damit ich mich auch Vertikal in der Spielwelt bewegen kann.|
| 3    |Muss             |Funktional|Als User möchte ich, dass wenn ich das Ende des Levels erreiche, dass das Spiel fertig ist, damit ich das Spiel auch durchspielen kann.|
| 4    |Kann             |Qualität|Als User möchte ich, dass die Plattformen Texturen haben, damit das Spiel für mich schöner aussieht.|
| 5    |Kann             |Qualität|Als User möchte ich, dass es Gegner gibt, damit das Spiel für mich schwieriger ist.|
| 6    |Kann             |Qualität|Als User möchte ich, dass ich eine Waffe habe, damit ich gegen die Gegner kämpfen kann.|
| 7    |Kann             |Qualität|Als User möchte ich, dass wenn ich ein Level fertig gespielt habe, dass ich ins Menu komme.|
| 8    |Kann             |Qualität|Als User möchte ich, dass jedes Level ein anderes Thema hat, damit das Spiel für mich interessanter wird.|
| 9    |Kann             |Qualität|Als User möchte ich, dass es bewegende Plattformen gibt, damit das Spiel für mich interessanter wird.|
|10    |Kann             |Qualität|Als User möchte ich, dass ich am Anfang auswählen kann, welches Level ich spielen will.|
|11    |Kann             |Qualität|Als User möchte ich, dass wenn ich ein Level fertig habe, dass ich ein neues Level auswählen kann oder das Level nochmal in einer schwereren Version spielen kann, damit das Spiel interessanter ist.|
|12    |Kann             |Qualität|Als User möchte ich, dass ich mehrere Waffen habe, die ich verwenden kann und unterschiedlichen Schaden machen, damit es interessanter wird.|
|13    |Kann             |Qualität|Als User möchte ich, dass man eine Healthbar hat, damit man sterben kann, aber nicht direkt stirbt.|
|14    |Kann             |Qualität|Als User möchte ich, dass es einen Shopkeeper gibt bei dem man neue Items, Heilung und anderes gibt, damit.|
|15    |Kann             |Qualität|Als User möchte ich, dass die Gegner eine Währung dropen, die man aufsammeln kann und verwenden kann, damit man stärker wird.|
|16    |Kann             |Qualität|Als User möchte ich, dass es einen Gegner gibt, der auf ein Spieler zuläuft und sich dann selbst in die Luft jagt, damit man ausweichen muss.|
|17    |Kann             |Qualität|Als User möchte ich, dass es einen Gegner gibt, der fliegt und von weit weg schiesst, damit man zielen muss.|



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1 |      Spiel gestartet        |     -    |         Spieler erscheint in einer Spielwelt.         |
| 1.2 |      Spiel wurde gestartet       |     A/D gedrückt    |          A -> Spieler läuft nach links, D -> Spieler läuft nach rechts.         |
| 2.1 |      Spiel wurde gestartet        |    Spacebar wurde gedrückt     |         Spieler springt vom Boden in die Luft und fällt wieder nach unten.          |
| 3.1 |   Spiel wurde seit einiger Zeit gespielt und alle Anforderungen sind erfüllt |   Level verlassen durch Tür oder Ähnliches |  Spieler kommt ins nächste Level.|
| 4.1 |   Spiel gestartet           |     -    |          Texturen sichtbar         |
| 5.1 |   Spiel gestartet und sich durch das Level bewegt.           |     A/D/Space    |          Monster erscheinen        | 
| 6.1 |   Waffe erhalten           |    Linksklick/Rechtsklick     |     Waffe verursacht Schaden an Gegnern und kann diese Töten.          |
| 7.1 |   Level abgeschlossen           |    -     |          Spieler wird wieder ins Menu gebracht, um ein neues Level zu spielen.         |
| 8.1 |   Level wird gestartet           |    -     | Level hat ein anderes Thema als das letzte Level.|
| 9.1 |   Spieler spielt Spiel| - |Plattform bewegt sich|
|10.1 | Spieler startet das Spiel| - |Level Auswahl erscheint|
|11.1 | Spieler beendet Level| - |Level Auswahl erscheint|
|12.1 | Spieler spielt Spiel|Taste für Waffe 1 wird gedrückt.|Schwert wird ausgewählt.|
|12.2 | Spieler spielt Spiel|Taste für Waffe 2 wird gedrückt.|Bogen wird ausgewählt.|
|13.1 | Spieler spielt Spiel| - |Healthbar wird angezeigt.|
|13.2 | Spieler spielt Spiel| Spieler wird von Monster getroffen.| Healthbar wird, nimmt ab.|
|14.1 | Spieler geht zu Shopkeeper| Spieler drückt die interagieren Taste bei dem Shopkeeper|Shopmenü erscheint.|
|14.2 | Spieler ist im Shopkeeper menü| Spieler drückt auf z. B. Heilung| Heilung wird dem Inventar des Spielers hinzugefügt.|
|15.1 | Spieler spielt Spiel| Spieler tötet Monster. |Monster lässt Währung fallen.|
|16.1 | Spieler spielt Spiel| - | Monster läuft zu Spieler.|
|16.2 | Spieler spielt Spiel| Spieler ist nahe am Monster.| Monster explodiert.|
|17.1 | Spieler spielt Spiel| - | Monster fliegt in der Luft.|
|17.2 | Spieler spielt Spiel| Spieler ist in der Nähe des Monsters.| Monster schiesst Pfeile.|



### 1.4 Diagramme


![Hauptprogramm 1](https://user-images.githubusercontent.com/110892382/220314476-1f001869-6247-4a86-bf20-a62031ee233b.png)
![Screenshot 2023-02-28 104558](https://user-images.githubusercontent.com/110892658/221815476-4e0ddd37-98c8-47c1-acc5-87ff822e8b07.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |28.02.2023|Jesenko|Spieler kann sich in der Welt bewegen.|45min|
| 2.A  |28.02.2023|Jesenko|Spieler kann Springen.|45min|
| 3.A  |07.03.2023|Veljkovic|Level kann beendet werden|45min|
| 4.A  |07.03.2023|Spycher|Texturen hinzufügen.|2x 45min|
| 5.A  |07.03.2023|Oesch|Gegner hinzufügen.|45min|
| 5.B  |07.03.2023|Oesch|Gegner Varianten hinzufügen.|45min|
| 6.A  |07.03.2023|Jesenko|Waffe hinzufügen.|45min|
| 7.A  |07.03.2023|Jesenko|Level Menü|45min|
| 8.A  |14.03.2023|Veljkovic|Level Themas erstellen.|45min|
| 9.A  |14.03.2023|Oesch|Bewegendeplattformen erstellen.|45min|
|10.A  |14.03.2023|Jesenko|Start Level Menü|45min|
|11.A  |14.03.2023|Spycher|Auswahl schwereres Level|45min|
|12.A  |14.03.2023|Jesenko|Mehrere Waffen hinzufügen.|45min|
|13.A  |21.03.2023|Spycher|Healthbar hinzufügen.|45min|
|14.A  |21.03.2023|Jesenko|Shopkeeper Menü hinzufügen.|45min|
|14.B  |21.03.2023|Jesenko|Items im Shopkeeper Menü hinzufügen.|45min|
|15.A  |21.03.2023|Veljkovic|Gegner lassen Währung fallen.|45min|
|15.B  |21.03.2023|Veljkovic| Währung kann aufgesammelt werden.|45min|
|16.A  |21.03.2023|Jesenko| Verfolgender Gegner.|45min|
|17.A  |21.03.2023|Oesch| Fliegender Gegner.|45min|


Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden


Wir haben uns dazu entschieden, dass wir keine weiteren Funktionen hinzufügen, weil die Umsetzung des Spiels in dieser Version sicher schon eine nicht ganz einfache Aufgabe wird.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |28.02.2023|Jesenko|45min|30min|
| 2.A  |28.02.2023|Jesenko|45min|30min|
| 3.A  |07.03.2023|Veljkovic|45min|50min|
| 4.A  |07.03.2023|Spycher|2x 45min||
| 5.A  |07.03.2023|Jesenko|45min|30min|
| 5.B  |07.03.2023|Jesenko|45min|30min|
| 6.A  |07.03.2023|Jesenko|45min|90min|
| 7.A  |07.03.2023|Jesenko|45min| |
| 8.A  |14.03.2023|Veljkovic|45min|45min|
| 9.A  |14.03.2023|Jesenko|45min|20min|
|10.A  |14.03.2023|Jesenko|45min| |
|11.A  |14.03.2023|Spycher|45min| |
|12.A  |14.03.2023|Jesenko|45min| |
|13.A  |21.03.2023|Spycher|45min|45min|
|14.A  |21.03.2023|Jesenko|45min| |
|14.B  |21.03.2023|Jesenko|45min| |
|15.A  |21.03.2023|Veljkovic|45min| |
|15.B  |21.03.2023|Veljkovic|45min| |
|16.A  |21.03.2023|Jesenko|45min|30min|
|17.A  |21.03.2023|Jesenko|45min|20min|

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |21.03.2023|OK|Stefan Jesenko|
| 1.2  |21.03.2023|OK|Stefan Jesenko|
| 2.1  |21.03.2023|OK|Stefan Jesenko|
| 3.1  |21.03.2023|OK|Stefan Jesenko|
| 4.1  |21.03.2023|NOK|Stefan Jesenko|
| 5.1  |21.03.2023|OK|Stefan Jesenko|
| 6.1  |21.03.2023|OK|Stefan Jesenko|
| 7.1  |21.03.2023|NOK|Stefan Jesenko|
| 8.1  |21.03.2023|OK|Stefan Jesenko|
| 9.1  |21.03.2023|OK|Stefan Jesenko|
|10.1  |21.03.2023|NOK|Stefan Jesenko|
|11.1  |21.03.2023|NOK|Stefan Jesenko|
|12.1  |21.03.2023|OK|Stefan Jesenko|
|12.2  |21.03.2023|NOK|Stefan Jesenko|
|13.1  |21.03.2023|OK|Stefan Jesenko|
|13.2  |21.03.2023|OK|Stefan Jesenko|
|14.1  |21.03.2023|NOK|Stefan Jesenko|
|14.2  |21.03.2023|NOK|Stefan Jesenko|
|15.1  |21.03.2023|NOK|Stefan Jesenko|
|16.1  |21.03.2023|OK|Stefan Jesenko|
|16.2  |21.03.2023|NOK|Stefan Jesenko|
|17.1  |21.03.2023|OK|Stefan Jesenko|
|17.2  |21.03.2023|OK|Stefan Jesenko|

Es ist uns aufgefallen, dass es zu aufwändig wird Texturen hinzuzufügen.
In unserem Spiel gibt es kein Level Menü, weil es aktuell so ist, dass man in unserem Spiel nach Abschluss eines Levels, automatisch in das nächste Level kommt.
Man startet im ersten Level und es gibt keine schwereren und leichteren Level, sondern es gibt nur eine Schwierigkeitsstufe.
Es gibt aktuell keine zweite Waffe in unserem Spiel.
Es ist uns aufgefallen, dass es keinen Sinn ergibt, dass es im Spiel einen Shopkeeper gibt und somit haben wir auch die Währung entfernt, weil diese dann keine Funktion hat.
Das Monster, das sich am Boden bewegt, schiesst auch Pfeile und explodiert nicht, weil das besser zum Spiel passt.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
