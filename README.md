
![Logo](https://sites.google.com/site/portcomptongjea/_/rsrc/1472690907149/missions/projetpersonnelencadre-bts/gsb.jpg)


# GSB | AP2 🔬

## Présentation de l'entreprise 🔍

GSB est un laboratoire pharmaceutique qui conserve et commercialise sur le marché des médicaments.

## Présentation du travail 🚧

Le laboratoire nous a contacté pour la mise en place d'une application dédiée au suivi des 
étapes de validation de mise sur le marché d'un médicament. Cette dernière aura pour but de rendre certaines 
tâches des employés plus simple.

L'application devra être faite en C# et relié à une base de données SQLServer.

Outils utilisés :

- Visual Studio 2022
- SQLServer

Le travail devait être rendu au plus tard le 14 Décembre 2022.

## Liste des tâches 📋

- Page de connexion
- Menu MDI (Multiple Document Interface)
- Page de saisie de la décision d'une étape
- Page de mise à jour des étapes normées
- Page d'ajout d'un nouveau médicament
- Page de consultation du Workflow des étapes d'un médicament
- Page de consultation du nombre de médicament autorisés par famille
- Page de consultation des médicaments en cours de validation
- Rédaction d'une notice techniques (triggers / procédures stockées)
- Rédaction notice d'installation du projet

## Guide d'installation ⚙️

Lien explication de l'installation : [Visual Studio 2022](https://learn.microsoft.com/fr-fr/visualstudio/install/install-visual-studio?view=vs-2022)

Lien explication de l'installation : [SQLServer](https://www.visual-expert.com/FR/visual-expert-documentation/install-and-configure-visual-expert/sql-server-2019-installation-guide.html)

## Guide installation BDD 🔧
- Se connecter à SQL server
- Clic droit sur le dossier "DataBases" ou "Base de données"
- cliquer sur "New DataBases" ou "Nouvelle Base de données"
- la nommer "GSB_gesAMM"
- Après avoir créer la nouvelle BDD
- Cliquer sur "New Query" ou "Nouvelle Requête"
- déplacer la BDD télécharger dans le dossier compressé dans la page qui vient de s'ouvir
- Appuyer sur "Execute" ou "Executer" et attendre quelques secondes
- la BDD est prête à l'emploi

## Guide création Trigger / Procédure stockée 📝

Pour ajouter des procédures stockées, vous aurez besoin de Microsoft SQL Server Management Studio.

Si vous possédez déjà le logiciel, rendez vous sur ce lien pour apprendre à rédiger des procédures stockées et triggers : [GUIDE CREATION TRIGGER/PROCEDURE](https://docs.google.com/document/d/1ELLMjNLmQSxK6Md6uXyJ_cbY4mLsq7_bVR2GfXbVBLI/edit?usp=sharing)

## Avant le lancement du projet ⌛
Tout d'abord, vous devez faire un clic droit sur Form1.cs et selectionner "Afficher le code".

Chercher cette ligne de code et remplacer "BTS2021-17" par le nom de votre Poste.
```
Globale.cnx.ConnectionString = "Data Source=BTS2021-17\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True";
```

- IDENTIFIANT : Administrateur
- MOT DE PASSE : Admin123

## Auteurs ✏️

- [@Swerk](https://www.github.com/SwerF) Oliwer SKWERES
- [@thomasl28500](https://www.github.com/thomasl28500) Thomas LETELLIER

