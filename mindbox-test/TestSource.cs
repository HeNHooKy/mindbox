﻿namespace mindbox_test
{
    public abstract class TestSource
    {
        public string TestName { get; }

        protected TestSource(string testName)
        {
            TestName = testName;
        }

        public override string ToString()
        {
            return TestName.ToString();
        }
    }
}
