namespace State.Structural
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Context
    {

        // Constructor
        public Context( State state )
        {
            State = state;
        }

        // Gets or sets the state
        public State State { get; set; }

        public void Request()
        {
            State.Handle( this );
        }
    }
}
