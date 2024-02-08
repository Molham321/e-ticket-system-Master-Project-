# Ecommerce Shop

Ein Materprojekt von Molham Al-khodari

## Überblick

Dieses Projekt dreht sich um eine Webanwendung für den Online-Kauf von Tickets.

### Benutzerfunktionen:

1. Durch die Seite navigieren
2. Nach Filmen suchen
3. Sich registrieren
4. Anmelden
5. Abmelden
7. Filme finden und Details anzeigen
8. Details zu Schauspielern und Kinos anzeigen
8. Kinotickets kaufen
9. Mit Paypal bezahlen
10. Bestellungen anzeigen

### Administratorfunktionen:

1. Kinos, Schauspieler und Filme erstellen, bearbeiten oder löschen
2. Alle Benutzer anzeigen
3. Alle Bestellungen anzeigen

## Installation

Um das Projekt zu verwenden, benötigen Sie Visual Studio 2022 und ASP.NET Version 6.0.

### 1. Repository klonen
Wählen Sie einen Ordner aus und öffnen Sie die Kommandozeile:

#### 1.1 Ordner auswählen und cmd öffnen
HTTPS-Variante: 

```
git clone https://git.ai.fh-erfurt.de/mo2467al/ecommerce-shop.git
```

SSH-Variante: 

```

git clone git@git.ai.fh-erfurt.de:mo2467al/ecommerce-shop.git
```

### Alternative: 1. Git initialisieren und Remote-Branch hinzufügen

```
git init
git remote add origin https://git.ai.fh-erfurt.de/mo2467al/ecommerce-shop.git
git pull origin main
```

Starten Sie dann das Projekt in Visual Studio 2022.

Falls Probleme auftreten, überprüfen Sie, ob eine Datenbank im SQL Server (localdb)\MSSQLLocalDB mit dem Namen "ecommerce-app-db" existiert. Andernfalls müssen Sie diese erstellen.

## Bezahlfunktion testen
Um die Bezahlfunktion zu testen, erstellen Sie einen Sandbox-Account auf PayPal Developer.

## Testanmeldung - Benutzer und Administrator
Zum Testen als Benutzer können Sie folgende Anmeldedaten verwenden:

E-Mail Adresse: ``user@test.com``<br>
Passwort: ``Test321.``<br><br><br>

Zum Testen als Administrator können Sie folgende Anmeldedaten verwenden:

E-Mail Adresse: ``admin@test.com``<br>
Passwort: ``Test321.``<br><br><br>



