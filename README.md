# Éditeur de graphes - dessin, édition et undo/redo

Application **C# / WinForms** qui permet de dessiner un graphe à la souris : création des nœuds, dessin des arrêtes, déplacement des noeuds, suppression.  
Chaque action peut-être annulée ou rétablie (undo-redo).

**Auteurs :** Rafaël HOCQUEL
**Version :** 1.0

## Ce que fait le programme

| # | Fonction | Geste |
|---|----------|-------|
| 1 | Créer un nœud | Clic gauche dans une zone vide |
| 2 | Relier deux nœuds | Clic sur un nœud, puis clic sur un autre (ou glisser jusqu'à ce dernier) |
| 3 | Créer un nœud au passage | Partir d'un nœud et relâcher dans le vide : le nœud est créé et relié |
| 4 | Déplacer un nœud | Bouton **Move Mode**, puis glisser (le nœud devient rouge pendant le déplacement) |
| 5 | Modifier un nœud | Clic droit → **Change** : couleur, épaisseur du trait, texte |
| 6 | Supprimer un nœud | Clic droit → **Delete** |
| 7 | Régler les prochains nœuds | Boutons **−** / **+** pour l'épaisseur (de 1 à 10) et **color** pour la couleur |
| 8 | Zoom et défilement | **Ctrl + molette** pour le zoom, barres de défilement horizontale et verticale |
| 9 | Annuler / rétablir | **Undo** et **Redo** dans le menu *Edit* (50 dernières actions) |
| 10 | Tout effacer | Bouton **Erase all graph** |

## Prérequis

- **Windows 10 / 11**
- **.NET 8 SDK** ou **Visual Studio 2022**

## Installation

```bash
git clone https://github.com/rafael-hocquel/PU-editeur-graphes.git
cd PU-editeur-graphes
dotnet run
