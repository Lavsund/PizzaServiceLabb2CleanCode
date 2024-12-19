# PizzaServiceLabb2CleanCode

En microservice för att hantera pizzor, skapad som en del av Labb 2 med fokus på Clean Code och SOLID-principer.

## Förkrav

För att köra detta projekt behöver du följande:
- [Docker Desktop](https://www.docker.com/products/docker-desktop) installerat.
- Tillgång till en terminal eller kommandoprompt.
- (Valfritt) [Visual Studio](https://visualstudio.microsoft.com/) eller en annan kodredigerare om du vill köra projektet utan Docker.

---

## Kom igång

### 1. Klona projektet
För att ladda ner koden till din lokala dator, kör följande kommando:
```bash
git clone https://github.com/Lavsund/PizzaServiceLabb2CleanCode.git
cd PizzaServiceLabb2CleanCode
```
### 2. Docker Hub
Hämta senaste versionen här: docker pull oloflav/pizza-service:latest

Starta med: docker run -p 8080:80 oloflav/pizza-service:latest

Öppna webbläsaren och skriv in: http://localhost:8080/swagger
