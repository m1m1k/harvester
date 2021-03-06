﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Compression;
using System.IO;
using System.Text.RegularExpressions;
using Harvester.Properties;
using System.Diagnostics;
using Diagnostics.Tracing;

namespace Harvester
{
    /// <summary>
    /// Represents the main class.
    /// </summary>
    public abstract class HarvestExperiment
    {
        public HarvestExperiment(string name)
        {

            this.WorkingDir = new DirectoryInfo(name);
        }

        public HarvestExperiment() 
        {
            var outpath = "data";
            if (!Directory.Exists(outpath))
                Directory.CreateDirectory(outpath);

            var time = DateTime.UtcNow;
            var experiment = Path.Combine(outpath, String.Format("{0}-{1}-{2} {3}h {4}m", time.Year, time.Month, time.Day, time.Hour, time.Minute));
            if (Directory.Exists(experiment))
                Directory.Delete(experiment);
            Directory.CreateDirectory(experiment);
            this.WorkingDir = new DirectoryInfo(experiment);
        }

        /// <summary>
        /// Gets the working directory of the experiment.
        /// </summary>
        public DirectoryInfo WorkingDir
        {
            get;
            private set;
        }

        /// <summary>
        /// Prepares the files in the experiment directory.
        /// </summary>
        /// <param name="processName">The process to analyze.</param>
        /// <param name="os">The operating system data collector.</param>
        /// <param name="pcm">The hardware counters data collector.</param>
        public abstract void Merge(string processName, HarvestProcess pcm, HarvestProcess os);


    }

    public struct CSwitch
    {
        public CSwitch(TraceEvent sw)
        {
            // Old thread id & process id
            this.OldThreadId = (int)sw.PayloadValue(0);
            this.OldProcessId = (int)sw.PayloadValue(1);
            this.NewThreadId = (int)sw.PayloadValue(3);
            this.NewProcessId = (int)sw.PayloadValue(4);
            this.State = (ThreadState)sw.PayloadValue(13);
            this.ProcessorNumber = sw.ProcessorNumber;
            this.TimeStamp = sw.TimeStamp;
            this.TimeStamp100ns = sw.TimeStamp100ns;
        }

        public readonly int OldThreadId;
        public readonly int OldProcessId;
        public readonly int NewThreadId;
        public readonly int NewProcessId;
        public readonly int ProcessorNumber;
        public readonly ThreadState State;
        public readonly DateTime TimeStamp;
        public readonly long TimeStamp100ns;
    }
}
