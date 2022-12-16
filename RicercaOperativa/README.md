Daniel Rota 5IC - Gestione Progetto - ITIS P. Paleocapa A.S. 2022/2023

<h1>RICERCA OPERATIVA</h1>

<h2>INTRODUZIONE GENERALE</h2>

L'applicativo a scopo didattico, intende simulare un contesto aziendale in cui è necessario allocare nella maniera più efficiente possibile tutte le risorse richieste da terzi, mediante l'utilizzo di appositi algoritmi che mirano a <i>ottimizzare</i> tempi e costi di trasporto, permettendo una maggiore efficienza da parte delle Unità Produttive, responsabili della produzione di beni e servizi.

Il software mette a disposizione diverse metodologie per la risoluzione del problema, tutte basate sull'utilizzo di una <i>matrice</i> come strumento di rappresentazione dello stesso.

<br>

<h2>UTILIZZO E INTERFACCIA</h2>

La sezione <i>Celle Matrice</i> richiede di definire il numero di Unità Produttive e Destinazioni facenti parte del contesto che si vuole rappresentare; attraverso il pulsante <i>Genera</i>, le prime vengono riportate sotto forma di righe nella matrice, mentre le seconde come colonne.

Il pulsante "<i>Riempi</i>" inserisce una serie di valori casuali nelle celle della matrice, i quali rappresentano i costi di trasporto da una specifica Unità Produttiva a una certa Destinazione; crea inoltre degli ulteriori valori casuali, relativi alle richieste delle singole Destinazioni e alle produzioni delle singole Unità Produttive (Ovviamente è importante che beni prodotti e beni richiesti coincidano).

Dopo aver inserito in ogni cella della matrice un valore numerico, ed essersi accertati che richieste e produzioni coincidano, è possibile scegliere una metodo di risoluzione del contesto fra i due disponibili; durante la fase di risoluzione non è ammessa la modifica di alcun valore presente nella matrice.

Dopo il termine dell'esecuzione, è possibile ricaricare la matrice utilizzata precedentemente, in modo da favorire il confronto fra i risultati derivanti da più elaborazioni di uno stesso set di dati, facendo uso di metodi diversi.

Il pulsante "<i>Ripristina</i>" riporta ogni controllo al proprio settaggio di default.

<br>

<h2>METODI</h2>

1. **NORD-OVEST**: Risolve il problema di allocazione dei beni, reiterando il calcolo della prima cella disponibile nella matrice (Quella "più a nord-ovest"), basando i processi interni proprio su questa.

2. **MINIMI COSTI**: Oltre che alla semplice distribuzione di risorse, questo metodo permette l'ottimizzazione dei costi, calcolando continuamente, fino a risoluzione completata, il trasporto più economico all'interno della situazione corrente.