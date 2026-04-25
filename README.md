# DocumentGenerator

## Descriere

Aplicatie dezvoltata in C# (.NET) care demonstreaza utilizarea pattern-urilor creationale pentru generarea de documente (rapoarte si facturi) in mai multe formate (HTML si Plain Text).

Aplicatia este construita modular si extensibil, folosind principii moderne de design.

---

## Structura proiectului

- DocumentGenerator/
  - Models
  - Exporters
  - Renderers
  - Factories
  - Builders
  - Prototypes
  - Configuration

- DocumentGenerator.Tests/
  - Teste unitare pentru toate pattern-urile

---

# Pattern-uri utilizate

## 1. Factory Method

### Problema rezolvată
Permite crearea de obiecte (exportere) fără a specifica clasa concretă, astfel încât codul client să nu depindă de implementări.

### Unde se regăsește în cod
- `DocumentExporter` (clasă abstractă)
- `HtmlDocumentExporter`
- `PlainTextDocumentExporter`
- metoda `CreateRenderer()`

---

## 2. Abstract Factory

### Problema rezolvată
Permite crearea de familii de obiecte (header, section, footer) fără a specifica clasele concrete, în funcție de tipul documentului (raport sau factură).

### Unde se regăsește în cod
- `IDocumentComponentFactory`
- `ReportComponentFactory`
- `InvoiceComponentFactory`
- utilizat în `DocumentAssembler`

---

## 3. Builder

### Problema rezolvată
Permite construirea pas cu pas a unui obiect complex (`DocumentData`) fără a avea un constructor foarte mare și greu de utilizat.

### Unde se regăsește în cod
- `DocumentData`
- `DocumentDataBuilder`
- metode fluente:
  - `WithTitle()`
  - `ByAuthor()`
  - `WithSection()`
  - `Build()`

---

## 4. Prototype

### Problema rezolvată
Permite clonarea obiectelor existente (șabloane de documente) fără a recrea manual fiecare proprietate.

### Unde se regăsește în cod
- `DocumentTemplate`
- metoda `Clone()`
- `TemplateRegistry` (stocare și reutilizare șabloane)

---

## 5. Singleton

### Problema rezolvată
Asigură existența unei singure instanțe globale pentru configurarea aplicației.

### Unde se regăsește în cod
- `AppConfiguration`
- proprietatea `Instance`

---

## Testare

Proiectul conține teste unitare (NUnit) pentru fiecare pattern:

- Factory Method → output diferit
- Abstract Factory → componente diferite
- Builder → validare date
- Prototype → clonare corectă
- Singleton → aceeași instanță

Toate testele trec cu succes.

---

## Rulare

1. Deschide proiectul în Visual Studio
2. Rulează aplicația
3. Se generează documente în funcție de configurație

---

## Tehnologii utilizate

- C# (.NET)
- NUnit
- Visual Studio