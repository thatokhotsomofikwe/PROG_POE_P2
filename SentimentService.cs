namespace PROG_POE_P2
{
    public class SentimentService
    {
        public string DetectSentiment(string message)
        {
            if (message.Contains("worried") || message.Contains("scared") || message.Contains("anxious") || message.Contains("nervous"))
                return "worried";

            if (message.Contains("curious") || message.Contains("interested") || message.Contains("tell me more"))
                return "curious";

            if (message.Contains("frustrated") || message.Contains("annoyed") || message.Contains("confused"))
                return "frustrated";

            return "";
        }

        public string GetEmpatheticMessage(string sentiment)
        {
            switch (sentiment)
            {
                case "worried":
                    return "It's completely understandable to feel that way. Scammers can be very convincing. Let me share a tip to help you stay safe.";

                case "curious":
                    return "Great! I love your curiosity. Here’s something useful for you.";

                case "frustrated":
                    return "I understand that cybersecurity can feel overwhelming at times. Let’s take it step by step. Here’s a tip that might help.";

                default:
                    return "";
            }
        }
    }
}