# Lern-Bericht
Stefan Jasenko, Jonah Oesch, Elias Spycher und 

## Einleitung

Wir haben in der Gruppe ein Jump and Run Spiel in Unity, einer Gameengine erstellt.

## Was haben wir gelernt?

Wie man einen Gradient in Unity benutzt.

## Beschreibung

Ein Gradient kann benutzt werden, um die Farbe eines `image` Elements zu ändern.
In unserem Spiel haben wir das gemacht, um besser darzustellen, wie viel Leben der Spieler noch hat, wenn die Lebensleiste voll ist, ist sie grün, nach einem Treffer wird sie gelb und dann rot. Ein Gradient kann fliessend oder fest von Farbe zu Farbe wechseln, bei uns wechselt der Gradient fest von Farbe zu Farbe, weil es besser zu unserem Spiel passt.

<img width="264" alt="image" src="https://user-images.githubusercontent.com/110892250/229684401-3d51bc55-e084-45cb-949b-0a649878dd6b.png">

Hier sieht man, wie das Fenster zur Erstellung eines Gradients aussieht. Man kann Punkte setzen um zu sagen in welchem Bereich es eine gewisse Farbe gibt.
Bei der `Mode` Einstellung kann man den Farbwechsel auf `fixed` oder `blend` stellen, um zu verändern, wie der Gradient von Farbe zu Farbe geht.

```C#
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
```

In diesem Code sieht man wie wir den `Gradient` im Code eingebaut haben. Da der `Gradient` mit Werten von 0 bis 1 arbeitet, wie der Gradient in der Funktion `SetMaxHealth`
auf 1 gesetzt. Da der `Slider` für die Lebensleiste von 0 bis 3 geht, muss der `Gradient` in der Funktion `SetHealth` normalisiert werden.

* Ein deutliches, aussagekräftiges Bild oder eine kommentierte Bildschirm-Aufnahme
* Ein gut dokumentierter Code-Fetzen
* Ein Link zu einem *selbst aufgenommenen* youtube-Video oder `.gif`.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflexion zum Arbeitsprozess

Wir konnten in der Gruppe sehr gut kommunizieren und miteinander arbeiten. Probleme konnten wir gemeinsam gut lösen

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
