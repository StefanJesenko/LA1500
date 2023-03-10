using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing.Telemetry
{
    class TelemetryMetricsService : ITelemetryMetricsService
    {
        readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;

        public TelemetryMetricsService(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper)
        {
            m_TelemetryMetricsInstanceWrapper = telemetryMetricsInstanceWrapper;
        }

        public void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition)
        {
            var handle = CreateAndStartMetricEvent(metricDefinition);
            timedAction();

            try
            {
                handle.StopAndSendMetric();
            }
            catch (IapTelemetryException exception)
            {
                Debug.unityLogger.LogIAPError($"An exception occured while sending a metric: {exception.Message}");
            }
        }

        public ITelemetryMetricEvent CreateAndStartMetricEvent(TelemetryMetricDefinition metricDefinition)
        {
            ITelemetryMetricEvent metricEvent = new TelemetryMetricEvent(m_TelemetryMetricsInstanceWrapper, metricDefinition.MetricType, metricDefinition.MetricName);

            try
            {
                metricEvent.StartMetric();
            }
            catch (IapTelemetryException exception)
            {
                Debug.unityLogger.LogIAPError($"An exception occured while starting a metric: {exception.Message}");
            }

            return metricEvent;
        }
    }
}
