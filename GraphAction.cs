 

namespace GraphDrawing
{



    internal class GraphAction
    {



        public GraphDrawing.GraphActionType Type { get; set; }

        public IDeletable? Subject { get; set; }

        public void Undo()
        {
            if (Subject == null) { return; }
            switch (Type)
            {
                case GraphDrawing.GraphActionType.Create: Subject.Deleted = true; break;
                case GraphDrawing.GraphActionType.Delete: Subject.Deleted = false; break;
                default:
                    // Comme dit dans le sujet " nous allons nous restreindre à la gestion « undo-redo » des actions Créer et Détruire" donc dans les autres cas on ne fait rien
                    break;
            }
        }

        public void Redo()
        {
            if (Subject == null) { return; }
            switch (Type)
            {
                case GraphDrawing.GraphActionType.Create: Subject.Deleted = false; break;
                case GraphDrawing.GraphActionType.Delete: Subject.Deleted = true; break;
                default:
                    // Comme dit dans le sujet " nous allons nous restreindre à la gestion « undo-redo » des actions Créer et Détruire" donc dans les autres cas on ne fait rien
                    break;
            }
        }
    }
}
