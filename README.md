# Éditeur de Graphes — C# / Windows Forms

Application desktop en C# et Windows Forms permettant de dessiner, manipuler et éditer des graphes directement à la souris (création et déplacement de sommets, tracé d'arêtes, personnalisation visuelle). L'éditeur intègre un système complet d'historique (**Undo / Redo**) ainsi que la gestion du zoom sur le canevas.

## Fonctionnalités principales

- **Édition interactive au curseur :** Création de nœuds à la volée, liaison par simple clic ou par glisser-déposer (*drag & drop*), et création automatique d'un sommet relié lorsqu'on relâche une arête dans le vide.
- **Personnalisation visuelle :** Réglage de la couleur (`color`) et de l'épaisseur du contour (boutons `-` / `+`, de 1 à 10) pour les futurs nœuds, ou modification individuelle d'un nœud existant (texte, couleur, épaisseur).
- **Historique d'actions (Undo / Redo) :** Annulation et rétablissement jusqu'aux 50 dernières opérations via le menu *Edit*.
- **Navigation sur le canevas :** Zoom fluide à la molette et déplacement via les barres de défilement horizontale et verticale.

## Contrôles et raccourcis

| Action | Manipulation |
| :--- | :--- |
| **Créer un nœud** | Clic gauche dans une zone vide du canevas |
| **Relier deux nœuds** | Clic sur un nœud source puis sur un nœud cible (ou glisser de l'un à l'autre) |
| **Créer et relier à la volée** | Tirer un trait depuis un nœud existant et relâcher le clic dans une zone vide |
| **Déplacer un nœud** | Activer le bouton **Move Mode**, puis glisser le nœud (il passe en rouge pendant le déplacement) |
| **Modifier un nœud** | Clic droit sur le nœud → **Change** (étiquette, couleur, épaisseur du trait) |
| **Supprimer un nœud** | Clic droit sur le nœud → **Delete** |
| **Zoomer / Dézoomer** | `Ctrl` + Molette de la souris |
| **Annuler / Rétablir** | Menu **Edit** → **Undo** / **Redo** |
| **Réinitialiser le canevas** | Bouton **Erase all graph** |

## Prérequis et lancement

- **OS :** Windows 10 / 11
- **Environnement :** .NET 8 SDK ou Visual Studio 2022

```bash
git clone https://github.com/rafael-hocquel/PU-editeur-graphes.git
cd PU-editeur-graphes
dotnet run
