import React, { useEffect, useState, createRef } from "react";
import classNames from "classnames";
import {
  CRow,
  CCol,
  CCard,
  CCardHeader,
  CCardBody,
  CSubheader,
  CBreadcrumbRouter,
  CLink,
} from "@coreui/react";
import { rgbToHex } from "@coreui/utils";
import { DocsLink } from "src/reusable";
import Board from "react-trello";
import CIcon from "@coreui/icons-react";
import moment from "moment";
import TimeLine from "react-gantt-timeline";

const TimeLineCom = () => {
  let d1 = new Date();
  let d2 = new Date();
  d2.setDate(d2.getDate() + 5);
  let d3 = new Date();
  d3.setDate(d3.getDate() + 8);
  let d4 = new Date();
  d4.setDate(d4.getDate() + 20);
  let d5 = new Date();
  d5.setDate(d5.getDate() + 30);

  let data = [
    { id: 1, start: d1, end: d2, name: "Demo Task 1" },
    { id: 2, start: d1, end: d2, color: "orange", name: "Demo Task 2" },
    { id: 3, start: d1, end: d2, name: "Demo Task 3" },
    { id: 4, start: d1, end: d3, name: "Demo Task 4" },
    { id: 5, start: d1, end: d4, name: "Demo Task 5" },
    { id: 6, start: d1, end: d5, name: "Demo Task 6" },
    { id: 7, start: d1, end: d2, name: "Demo Task 7" },
    { id: 8, start: d1, end: d4, name: "Demo Task 8" },
    { id: 9, start: d1, end: d4, name: "Demo Task 9" },
    { id: 10, start: d1, end: d5, name: "Demo Task 10" },
    { id: 11, start: d1, end: d3, name: "Demo Task 11" },
    { id: 12, start: d1, end: d2, name: "Demo Task 12" },
    { id: 13, start: d2, end: d5, name: "Demo Task 13" },
    { id: 14, start: d3, end: d5, color: "orange", name: "Demo Task 14" },
    { id: 1, start: d4, end: d2, name: "Demo Task 1" },
    { id: 2, start: d1, end: d2, name: "Demo Task 2" },
    { id: 3, start: d1, end: d2, name: "Demo Task 3" },
    { id: 4, start: d1, end: d2, name: "Demo Task 4" },
    { id: 5, start: d1, end: d2, name: "Demo Task 5" },
    { id: 6, start: d1, end: d2, name: "Demo Task 6" },
    { id: 7, start: d1, end: d2, color: "red", name: "Demo Task 7" },
    { id: 8, start: d1, end: d2, name: "Demo Task 8" },
    { id: 9, start: d1, end: d2, name: "Demo Task 9" },
    { id: 10, start: d1, end: d2, name: "Demo Task 10" },
    { id: 11, start: d1, end: d2, name: "Demo Task 11" },
    { id: 12, start: d1, end: d2, name: "Demo Task 12" },
    { id: 13, start: d1, end: d2, name: "Demo Task 13" },
    { id: 14, start: new Date(), end: new Date() + 1, name: "Demo Task 14" },
    { id: 1, start: new Date(), end: new Date() + 1, name: "Demo Task 1" },
    { id: 2, start: new Date(), end: new Date() + 1, name: "Demo Task 2" },
    { id: 3, start: new Date(), end: new Date() + 1, name: "Demo Task 3" },
    { id: 4, start: new Date(), end: new Date() + 1, name: "Demo Task 4" },
    { id: 5, start: new Date(), end: new Date() + 1, name: "Demo Task 5" },
    { id: 6, start: new Date(), end: new Date() + 1, name: "Demo Task 6" },
    { id: 7, start: new Date(), end: new Date() + 1, name: "Demo Task 7" },
    { id: 8, start: new Date(), end: new Date() + 1, name: "Demo Task 8" },
    { id: 9, start: new Date(), end: new Date() + 1, name: "Demo Task 9" },
    { id: 10, start: new Date(), end: new Date() + 1, name: "Demo Task 10" },
    { id: 11, start: new Date(), end: new Date() + 1, name: "Demo Task 11" },
    { id: 12, start: new Date(), end: new Date() + 1, name: "Demo Task 12" },
    { id: 13, start: new Date(), end: new Date() + 1, name: "Demo Task 13" },
    { id: 14, start: new Date(), end: new Date() + 1, name: "Demo Task 14" },
  ];
  let links = [
    { id: 1, start: 1, end: 2 },
    { id: 2, start: 1, end: 3 },
  ];

  useEffect(() => {}, []);

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
      <TimeLine data={data} links={links} />
    </CCard>
  );
};
export default TimeLineCom;
