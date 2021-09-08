# UI

## Mockups vs Endergebnis

Warum abweicht unser Endprodukt von erstellten Mockups?

Am Anfang wollten wir ein einfaches Design für all die Views gestalten und mit Hilfe von verschiedener Farbe, die «views» unterscheiden.

Jedoch haben wir schnell gemerkt, dass WindowsForms sehr limitiert ist.

Sowohl ich als auch Raphael sind daran gewohnt mit guten Frameworks in WEB Bereich zu arbeiten, welche uns viele Möglichkeiten anbieten und deswegen, dachten wir dass wir hier auch umsetzen könnten, aber das war nicht wirklich möglich.

### Dashboard

#### Vor-/Nachteile

Vorteile       | Nachteile
-------------- | -----------------------
Schnellzugriff | Mehrmals gleiche Aktion
Zähler         | Responsive

Mockup                                                 | Result
------------------------------------------------------ | ------------------------------------------------------
![ui-dashboard-mockup](images/ui-dashboard-mockup.png) | ![ui-dashboard-result](images/ui-dashboard-result.png)

### Customers

#### Vor-/Nachteile

Vorteile                  | Nachteile
------------------------- | ---------------
Keine Zusätzliche Fenster | Unübersichtlich
...                       | Responsive

Mockup                                                 | Result
------------------------------------------------------ | ------------------------------------------------------
![ui-customers-mockup](images/ui-customers-mockup.png) | ![ui-customers-result](images/ui-customers-result.png)

### Categories

#### Vor-/Nachteile

Vorteile                  | Nachteile
------------------------- | ---------------
Keine Zusätzliche Fenster | Unübersichtlich
...                       | Responsive

Mockup                                                   | Result
-------------------------------------------------------- | --------------------------------------------------------
![ui-categories-mockup](images/ui-categories-mockup.png) | ![ui-categories-result](images/ui-categories-result.png)

### Catalog

#### Vor-/Nachteile

Vorteile             | Nachteile
-------------------- | ---------
Zugriff auf Produkte |

Mockup                                             | Result
-------------------------------------------------- | --------------------------------------------------
![ui-catalog-mockup](images/ui-catalog-mockup.png) | ![ui-catalog-result](images/ui-catalog-result.png)

### Orders

#### Vor-/Nachteile

Vorteile                  | Nachteile
------------------------- | ---------------
Keine Zusätzliche Fenster | Unübersichtlich
...                       | Responsive

Mockup                                           | Result
------------------------------------------------ | ------------------------------------------------
![ui-orders-mockup](images/ui-orders-mockup.png) | ![ui-orders-result](images/ui-orders-result.png)

### Products

#### Vor-/Nachteile

Vorteile                  | Nachteile
------------------------- | ---------------
Keine Zusätzliche Fenster | Unübersichtlich
..                        | Responsive

Mockup                                               | Result
---------------------------------------------------- | ----------------------------------------------------
![ui-products-mockup](images/ui-products-mockup.png) | ![ui-products-result](images/ui-products-result.png)

### Settings

#### Vor-/Nachteile

Vorteile                           | Nachteile
---------------------------------- | ---------
Diverse Einstellung auf eine Seite |

Mockup                                               | Result
---------------------------------------------------- | ------
![ui-settings-mockup](images/ui-settings-mockup.png) | -

## Modal Forms

Wir haben uns am Angang entschieden, alle Grids + Formulare auf ein Panel darzustellen.

Im Verlauf von der Entwicklung haben wir nun gemerkt, dass das nicht so wirklich übersichtlich ist.

Deswegen haben wir uns dann entschieden, all die Formulare in einer separaten Modal Fenster anzuzeigen.

Somit erreichen wir ein besseres Design für unsere Grid und die ADD und DELETE Operationen, können sauber über dieses Modal Dialog gelöst werden.

Beim Klicken auf «Add» wird das Formular gelöscht und eine neuen Datensatz kann erfasst werden.

Wenn 1 Datensatz im Grid ausgewählt ist, dann kann man auf «Edit» Button drücken, das Modal wird geöffnet und die Felder werden mit der ausgewählte Datensatz gefüllt.

Beim Speichern wird dann beachtet, ob die Datensatz bereits ein ID hat oder nicht.

Falls ja, werden die Felder in der DB geändert, falls nicht, wird eine neue Datensatz in der DB angelegt

Add Mode                                                           | Edi Mode
------------------------------------------------------------------ | ------------------------------------------------------------------
![modal-form-products-add](images/modal-form-products-add.png)     | ![modal-form-products-edit](images/modal-form-products-edit.png)
![modal-form-categories-add](images/modal-form-categories-add.png) | ![modal-form-categories-add](images/modal-form-categories-add.png)
![modal-form-customers-add](images/modal-form-customers-add.png)   | ![modal-form-customers-add](images/modal-form-customers-add.png)
![modal-form-orders-add](images/modal-form-orders-add.png)         | ![modal-form-orders-add](images/modal-form-orders-add.png)
