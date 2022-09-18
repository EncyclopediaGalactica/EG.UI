namespace EncyclopediaGalactica.UI.FAST;

public struct Configuration
{
    public struct Button
    {
        public struct Type
        {
            public const string Submit = "submit";
            public const string Reset = "reset";
            public const string Button = "button";
        }
    }
    public struct Form
    {
        /// <summary>
        /// The available Form methods
        /// </summary>
        public struct Method
        {
            public const string Get = "Get";
            public const string Post = "Post";
        }

        /// <summary>
        /// The available form targets
        /// </summary>
        public struct Target
        {
            public const string Self = "_self";
            public const string Blank = "_blank";
            public const string Parent = "_parent";
            public const string Top = "_top";
        }
    }

    public struct Appearance
    {
        public const string Accent = "accent";
        public const string Lightweight = "lightweight";
        public const string Neutral = "neutral";
        public const string Outline = "outline";
        public const string Stealth = "stealth";
        public const string Hypertext = "hypertext";
    }
}