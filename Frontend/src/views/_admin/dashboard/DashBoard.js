import React, { useState, useEffect } from "react";
import {
  CCard,
  CCardBody,
  CCardGroup,
  CCardHeader,
  CSubheader,
  CLink,
  CCol,
  CWidgetBrand,
  CRow,
  CWidgetIcon,
} from "@coreui/react";
import {
  CChartBar,
  CChartLine,
  CChartDoughnut,
  CChartRadar,
  CChartPie,
  CChartPolarArea,
} from "@coreui/react-chartjs";
import { DocsLink } from "src/reusable";
import CIcon from "@coreui/icons-react";
import axios from "axios";

const DashBoards = () => {
  return (
    <CCard>
      <CSubheader className="px-3 justify-content-between">
        <div className="d-md-down-none mfe-2 c-subheader-nav">
          <CLink
            className="c-subheader-nav-link"
            aria-current="page"
            to="/dashboard"
          >
            <CIcon name="cil-graph" alt="Dashboard" />
            &nbsp;Tên dự án
          </CLink>
        </div>
        <div className="d-md-down-none mfe-2 c-subheader-nav">
          <CLink className="c-subheader-nav-link" href="#">
            <CIcon name="cil-speech" alt="Settings" />
          </CLink>
          <CLink
            className="c-subheader-nav-link"
            aria-current="page"
            to="/dashboard"
          >
            <CIcon name="cil-graph" alt="Dashboard" />
            &nbsp;Dashboard
          </CLink>
          <CLink className="c-subheader-nav-link" href="#">
            <CIcon name="cil-settings" alt="Settings" />
            &nbsp;Settings
          </CLink>
        </div>
      </CSubheader>
      <CRow>
        <CCol xs="12" sm="6" lg="3">
          <CWidgetIcon text="Completed tasks" header="100" color="primary">
            <CIcon width={24} name="cil-settings" />
          </CWidgetIcon>
        </CCol>
        <CCol xs="12" sm="6" lg="3">
          <CWidgetIcon text="Incomplete task" header="50" color="info">
            <CIcon width={24} name="cil-user" />
          </CWidgetIcon>
        </CCol>
        <CCol xs="12" sm="6" lg="3">
          <CWidgetIcon text="Overdue tasks" header="10" color="warning">
            <CIcon width={24} name="cil-moon" />
          </CWidgetIcon>
        </CCol>
        <CCol xs="12" sm="6" lg="3">
          <CWidgetIcon text="Total tasks" header="160" color="danger">
            <CIcon width={24} name="cil-bell" />
          </CWidgetIcon>
        </CCol>
      </CRow>
      <CCardGroup columns className="cols-2">
        <CCard>
          <CCardHeader>
            Bar Chart
            <DocsLink href="http://www.chartjs.org" />
          </CCardHeader>
          <CCardBody>
            <CChartBar
              datasets={[
                {
                  label: "GitHub Commits",
                  backgroundColor: "#f87979",
                  data: [40, 20, 12, 39, 10, 40, 39, 80, 40, 20, 12, 11],
                },
              ]}
              labels="months"
              options={{
                tooltips: {
                  enabled: true,
                },
              }}
            />
          </CCardBody>
        </CCard>

        <CCard>
          <CCardHeader>Doughnut Chart</CCardHeader>
          <CCardBody>
            <CChartDoughnut
              datasets={[
                {
                  backgroundColor: ["#41B883", "#E46651", "#00D8FF", "#DD1B16"],
                  data: [40, 20, 80, 10],
                },
              ]}
              labels={["VueJs", "EmberJs", "ReactJs", "AngularJs"]}
              options={{
                tooltips: {
                  enabled: true,
                },
              }}
            />
          </CCardBody>
        </CCard>

        <CCard>
          <CCardHeader>Line Chart</CCardHeader>
          <CCardBody>
            <CChartLine
              datasets={[
                {
                  label: "Data One",
                  backgroundColor: "rgb(228,102,81,0.9)",
                  data: [30, 39, 10, 50, 30, 70, 35],
                },
                {
                  label: "Data Two",
                  backgroundColor: "rgb(0,216,255,0.9)",
                  data: [39, 80, 40, 35, 40, 20, 45],
                },
              ]}
              options={{
                tooltips: {
                  enabled: true,
                },
              }}
              labels="months"
            />
          </CCardBody>
        </CCard>

        <CCard>
          <CCardHeader>Pie Chart</CCardHeader>
          <CCardBody>
            <CChartPie
              datasets={[
                {
                  backgroundColor: ["#41B883", "#E46651", "#00D8FF", "#DD1B16"],
                  data: [40, 20, 80, 10],
                },
              ]}
              labels={["VueJs", "EmberJs", "ReactJs", "AngularJs"]}
              options={{
                tooltips: {
                  enabled: true,
                },
              }}
            />
          </CCardBody>
        </CCard>
      </CCardGroup>
    </CCard>
  );
};

export default DashBoards;
