using Godot;

namespace Yarn.GodotYarn {
        /// <summary>
        /// An object that can be used to signal to a coroutine that it should
        /// terminate early.
        /// </summary>
        /// <remarks>
        /// <para>
        /// While coroutines can be stopped by calling <see
        /// cref="MonoBehaviour.StopCoroutine"/> or <see
        /// cref="MonoBehaviour.StopAllCoroutines"/>, this has the side effect
        /// of also stopping any coroutine that was waiting for the now-stopped
        /// coroutine to finish.
        /// </para>
        /// <para>
        /// Instances of this class may be passed as a parameter to a coroutine
        /// that they can periodically poll to see if they should terminate
        /// earlier than planned.
        /// </para>
        /// <para>
        /// To use this class, create an instance of it, and pass it as a
        /// parameter to your coroutine. In the coroutine, call <see
        /// cref="Start"/> to mark that the coroutine is running. During the
        /// coroutine's execution, periodically check the <see
        /// cref="WasInterrupted"/> property to determine if the coroutine
        /// should exit. If it is <see langword="true"/>, the coroutine should
        /// exit (via the <c>yield break</c> statement.) At the normal exit of
        /// your coroutine, call the <see cref="Complete"/> method to mark that the
        /// coroutine is no longer running. To make a coroutine stop, call the
        /// <see cref="Interrupt"/> method.
        /// </para>
        /// <para>
        /// You can also use the <see cref="CanInterrupt"/> property to
        /// determine if the token is in a state in which it can stop (that is,
        /// a coroutine that's using it is currently running.)
        /// </para>
        /// </remarks>
        public class CoroutineInterruptToken {
            /// <summary>
            /// The state that the token is in.
            /// </summary>
            enum State {
                NotRunning,
                Running,
                Interrupted,
            }

            private State state = State.NotRunning;

            public bool CanInterrupt => state == State.Running;
            public bool WasInterrupted => state == State.Interrupted;
            public void Start() {
                state = State.Running;
                // GD.Print(nameof(CoroutineInterruptToken), " starting.");
            }
            public void Interrupt() {
                if (CanInterrupt == false) {
                    throw new System.InvalidOperationException($"Cannot stop {nameof(CoroutineInterruptToken)}; state is {state} (and not {nameof(State.Running)}");
                }
                state = State.Interrupted;
                // GD.Print(nameof(CoroutineInterruptToken), " interrupted.");
            }

            public void Complete() {
                // GD.Print(nameof(CoroutineInterruptToken), " completed.");
                state = State.NotRunning;
            }
        }
}