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
  CWidgetIcon,
  CCardFooter,
  CWidgetSimple,
  CContainer,
  CWidgetProgressIcon,
  CButton,
  CFormGroup,
  CLabel,
  CInput,
  CSelect
} from "@coreui/react";
import { rgbToHex } from "@coreui/utils";
import { DocsLink } from "src/reusable";
import Board from "react-trello";
import CIcon from "@coreui/icons-react";
import ChartLineSimple from "../../charts/ChartLineSimple";
import "./Home.css";
import { freeSet } from "@coreui/icons";
import axios from "axios";
import { CustomDialog, useDialog } from "react-st-modal";

function handleClick(type) {
  console.log(type);
}
function CustomDialogContent() {
  // use this hook to control the dialog
  const dialog = useDialog();

  const [value, setValue] = useState();

  return (
    <CCol xs="12" sm="12">
      <CCard>
        <CCardHeader>
          Khởi tạo một dự án
          <small> Create</small>
          <DocsLink name="-Input" />
        </CCardHeader>
        <CCardBody>
          <CRow>
            <CCol xs="12">
              <CFormGroup>
                <CLabel htmlFor="projectName">Tên dự án</CLabel>
                <CInput
                  id="projectName"
                  placeholder="Vui lòng nhập tên dự án"
                  required
                />
              </CFormGroup>
            </CCol>
          </CRow>
          <CRow>
            <CCol xs="12">
              <CFormGroup>
                <CLabel htmlFor="sortName">Tên ngắn</CLabel>
                <CInput
                  id="sortName"
                  placeholder="Vui lòng nhập tên ngắn"
                  required
                />
              </CFormGroup>
            </CCol>
          </CRow>
          <CCol col="5" sm="4" md="2" xl className="mb-3 mb-xl-0"></CCol>
          <CCol col="2" sm="4" md="2" xl className="mb-3 mb-xl-0">
            <CButton block color="primary">
              Tạo
            </CButton>
          </CCol>
        </CCardBody>
      </CCard>
    </CCol>
  );
}

function renderArticles(projects) {
  if (projects.length > 0) {
    return projects.map((project, index) => (
      <CCol sm="6" md="2" key={index}>
        <CWidgetProgressIcon
          onClick={() => handleClick(project.sortName)}
          header={project.projectName}
          text={project.sortName}
          color="gradient-info"
          inverse
        >
          <CIcon name="cil-people" height="36" />
        </CWidgetProgressIcon>
      </CCol>
    ));
  } else return [];
}

const Home = () => {
  const [data, setData] = useState([]);

  useEffect(async () => {
    var config = {
      headers: {
        "Access-Control-Allow-Origin": "*",
        "Access-Control-Allow-Methods": "GET,PUT,POST,DELETE,PATCH,OPTIONS",
      },
    };
    const result = await axios("https://localhost:44363/api/Projects1", config);
    setData(result.data);
    console.log(result.data);
  }, []);

  const articles = renderArticles(data);

  function handleClick(type) {
    console.log(type);
  }

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
            &nbsp;Chào mừng bạn đến với metalon
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
      <CContainer fluid>
        <CRow style={{ marginTop: "20px" }}>
          <CCol sm="2" md="2">
            <CButton
              block
              color="info"
              onClick={async () => {
                const result = await CustomDialog(<CustomDialogContent />, {
                  title: "Custom Dialog",
                  showCloseIcon: true,
                });
              }}
            >
              Tạo dự án mới
            </CButton>
          </CCol>
        </CRow>
        <CRow style={{ marginTop: "20px" }}>{articles}</CRow>
      </CContainer>
    </CCard>
  );
};
export default Home;
