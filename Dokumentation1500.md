# Projekt-Dokumentation

Poppy Jesenko, Oesch, Spycher und Veljkovic

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|21.02.2022| 0.0.1|Wir haben uns heute zuerst etwas in der Gruppe kennengelernt, in einer zweiten Phase haben wir uns entschieden, dass wir ein 2D jump and run spiel machen wollen.|
|28.02.2022| 0.0.2|  WIr haben an unserem Projekt weitergearbeitet und die Dokumentation weiter bearbeitet.|
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Wir machen ein 2D jump and run in Unity.

 
Wir haben vor ein 2D jump and run in Unity zu machen, wir haben uns gedacht, dass wir zuerst ein kleines 2D spiel, machen, indem ein Spieler von Plattform zu Plattform springen kann, wenn wir das geschafft haben, ist unser Ziel das wir ein 2D Jump and Run machen mit mehreren Leveln indem es Gegner gibt, die der Spieler auch bekämpfen kann. Unser Ziel ist es dabei zu lernen wie man ein Spiel in Unity programmiert.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |Muss             |Funktional|Als User möchte ich, dass wenn ich das Spiel starte, dass ich dann in einem Level bin und mich bewegen kann, damit ich das Spiel spielen kann.|
| 2    |Muss             |Funktional|Als User möchte ich, dass mein Charakter springen kann, damit ich mich auch Vertikal in der Spielwelt bewegen kann.|
| 3    |Muss             |Funktional|Als User möchte ich, dass wenn ich das Ende des Levels erreiche, dass das Spiel fertig ist, damit ich das Spiel auch durchspielen kann.|
| 4    |Kann             |Qualität|Als User möchte ich, dass die Plattformen Texturen haben, damit das Spiel für mich schöner aussieht.|
| 5    |Kann             |Qualität|Als User möchte ich, dass es Gegner gibt, damit das Spiel für mich schwieriger ist.|
| 6    |Kann             |Qualität|Als User möchte ich, dass ich eine Waffe habe, damit ich gegen die Gegner kämpfen kann.|
| 7    |Kann             |Qualität|Als User möchte ich, dass wenn ich ein Level fertig gespielt habe dass ich ins Menu komme.|
| 8    |Kann             |Qualität|Als User möchte ich, dass jedes Level ein anderes Thema hat, damit das Spiel für mich interessanter wird.|
| 9    |Kann             |Qualität|Als User möchte ich, dass es bewegende Plattformen gibt, damit das Spiel für mich interessanter wird.|
|10    |Kann             |Qualität|Als User möchte ich, dass ich am Anfang auswählen kann, welches Level ich spielen will.|
|11    |Kann             |Qualität|Als User möchte ich, dass wenn ich ein Level fertig habe das ich ein neues Level auswählen kann oder das Level nöchmal in einer schwereren Version spielen kann, damit das Spiel interessanter ist.|
|12    |Kann             |Qualität|Als User möchte ich, dass ich mehrere Waffen habe die ich verwenden kann und unterschiedlichen Schaden machen, damit es interessanter WIrd.|
|13    |Kann             |Qualität|Als User möchte ich, dass man eine Healthbar hat, damit man sterben kann aber nicht direkt stirbt.|
|14    |Kann             |Qualität|Als User möchte ich, dass es einen Shopkeeper gibt bei dem man neue Items, Heilung und anderes gibt, damit .|
|15    |Kann             |Qualität|Als User möchte ich, dass die Gegner eine Währung dropen die man aufsammeln kann und verwenden kann, damit man stärker wird.|
|16    |Kann             |Qualität|Als User möchte ich, dass es einen Gegener gibt der auf edn Spieler zuläuft und sich dann selbst in die Luft jagt, damit man ausweichen muss.|
|17    |Kann             |Qualität|Als User möchte ich, dass es einen Gegener gibt der fliegt und von weit weg schiesst, damit man zielen muss.|


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1 |      Spiel gestartet        |     -    |         Spieler erscheint in einer Spielwelt.         |
| 2.1 |      Spiel wurde gestartet       |     A/D gedrückt    |          A -> Spieler läuft nach links, D -> Spieler läuft nach rechts.         |
| 3.2 |      Spiel wurde gestartet        |    Spacebar wurde gedrückt     |         Spieler springt vom Boden in die Luft und fällt wieder nach unten.          |
| 4.3 |   Spiel wurde seit einiger Zeit gespielt und alle Anforderungen sind erfüllt |   Level verlassen durch Tür oder Ähnliches |  Spieler wird gelobt.        |
| 5.4 |   Spiel gestartet           |     -    |          Texturen sichtbar         |
| 6.5 |   Spiel gestartet und sich durch das Level bewegt.           |     A/D/Space    |          Monster erscheinen und greifen Spieler an.         |
| 7.6 |   Waffe eingesammelt           |    Linksklick/Rechtsklick     |     Waffe verursacht Schaden an Gegnern und kann diese Töten.          |
| 8.7 |   Level abgeschlossen           |    -     |          Spieler wird wieder ins Menu gebracht um ein neues Level zu spielen.         |
| 9.8 |   Level wird gestartet           |    -     |      Map              |
| 2. |              |         |                   |
| 2. |              |         |                   |
| 2.  |              |         |                   |
| 2.  |              |         |                   |
| 2.  |              |         |                   |
| 2.  |              |         |                   |
| 2.  |              |         |                   |
✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme


![Hauptprogramm 1](https://user-images.githubusercontent.com/110892382/220314476-1f001869-6247-4a86-bf20-a62031ee233b.png)
![Screenshot 2023-02-21 113049](https://user-images.githubusercontent.com/110892658/220320087-f3a02e93-4715-4e55-99af-3b027f15ebfb.png)
## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |   28.02.2023    |     Jasenko      |       Grundlegenes Movement und Kollisionen       |        60 min       |
| 2.B  |   28.02.2023    |     Jasenko      |       Springen bei Spacebar       |       30 min        |
| 3.C  |   28.02.2023    |           |              |               |
| 1.D  |   28.02.2023    |           |              |               |
| 1.E  |   28.02.2023    |           |              |               |
| 1.F  |   28.02.2023    |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
