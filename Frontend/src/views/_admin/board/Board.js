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
  CButton,
  CFormGroup,
  CLabel,
  CInput,
  CCollapse,
  CDropdownItem,
  CDropdownMenu,
  CDropdownToggle,
  CFade,
  CForm,
  CFormText,
  CValidFeedback,
  CInvalidFeedback,
  CTextarea,
  CInputFile,
  CInputCheckbox,
  CInputRadio,
  CInputGroup,
  CInputGroupAppend,
  CInputGroupPrepend,
  CDropdown,
  CInputGroupText,
  CSelect,
  CSwitch
} from "@coreui/react";
import { rgbToHex } from "@coreui/utils";
import { DocsLink } from "src/reusable";
import Board from "react-trello";
import CIcon from "@coreui/icons-react";
import { CustomDialog, useDialog } from "react-st-modal";

function CustomDialogContent() {
  // use this hook to control the dialog
  const dialog = useDialog();

  const [value, setValue] = useState();

  return (
    <CCol xs="12" md="12">
    <CCard>
      <CCardHeader>
        Tạo task mới
        <small> Elements</small>
      </CCardHeader>
      <CCardBody>
        <CForm action="" method="post" encType="multipart/form-data" className="form-horizontal">
          <CFormGroup row>
            <CCol md="3">
              <CLabel>Static</CLabel>
            </CCol>
            <CCol xs="12" md="9">
              <p className="form-control-static">Username</p>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel htmlFor="text-input">Text Input</CLabel>
            </CCol>
            <CCol xs="12" md="9">
              <CInput id="text-input" name="text-input" placeholder="Text" />
              <CFormText>This is a help text</CFormText>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel htmlFor="email-input">Email Input</CLabel>
            </CCol>
            <CCol xs="12" md="9">
              <CInput type="email" id="email-input" name="email-input" placeholder="Enter Email" autoComplete="email"/>
              <CFormText className="help-block">Please enter your email</CFormText>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel htmlFor="password-input">Password</CLabel>
            </CCol>
            <CCol xs="12" md="9">
              <CInput type="password" id="password-input" name="password-input" placeholder="Password" autoComplete="new-password" />
              <CFormText className="help-block">Please enter a complex password</CFormText>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel htmlFor="date-input">Date Input</CLabel>
            </CCol>
            <CCol xs="12" md="9">
              <CInput type="date" id="date-input" name="date-input" placeholder="date" />
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel htmlFor="disabled-input">Disabled Input</CLabel>
            </CCol>
            <CCol xs="12" md="9">
              <CInput id="disabled-input" name="disabled-input" placeholder="Disabled" disabled />
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel htmlFor="textarea-input">Textarea</CLabel>
            </CCol>
            <CCol xs="12" md="9">
              <CTextarea 
                name="textarea-input" 
                id="textarea-input" 
                rows="9"
                placeholder="Content..." 
              />
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel htmlFor="select">Select</CLabel>
            </CCol>
            <CCol xs="12" md="9">
              <CSelect custom name="select" id="select">
                <option value="0">Please select</option>
                <option value="1">Option #1</option>
                <option value="2">Option #2</option>
                <option value="3">Option #3</option>
              </CSelect>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel htmlFor="selectLg">Select Large</CLabel>
            </CCol>
            <CCol xs="12" md="9" size="lg">
              <CSelect custom size="lg" name="selectLg" id="selectLg">
                <option value="0">Please select</option>
                <option value="1">Option #1</option>
                <option value="2">Option #2</option>
                <option value="3">Option #3</option>
              </CSelect>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel htmlFor="selectSm">Select Small</CLabel>
            </CCol>
            <CCol xs="12" md="9">
              <CSelect custom size="sm" name="selectSm" id="SelectLm">
                <option value="0">Please select</option>
                <option value="1">Option #1</option>
                <option value="2">Option #2</option>
                <option value="3">Option #3</option>
                <option value="4">Option #4</option>
                <option value="5">Option #5</option>
              </CSelect>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel htmlFor="disabledSelect">Disabled Select</CLabel>
            </CCol>
            <CCol xs="12" md="9">
              <CSelect 
                custom 
                name="disabledSelect" 
                id="disabledSelect" 
                disabled 
                autoComplete="name"
              >
                <option value="0">Please select</option>
                <option value="1">Option #1</option>
                <option value="2">Option #2</option>
                <option value="3">Option #3</option>
              </CSelect>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol tag="label" sm="3" className="col-form-label">
              Switch checkboxes
            </CCol>
            <CCol sm="9">
              <CSwitch
                className="mr-1"
                color="primary"
                defaultChecked
              />
              <CSwitch
                className="mr-1"
                color="success"
                defaultChecked
                variant="outline"
              />
              <CSwitch
                className="mr-1"
                color="warning"
                defaultChecked
                variant="opposite"
              />
              <CSwitch
                className="mr-1"
                color="danger"
                defaultChecked
                shape="pill"
              />
              <CSwitch
                className="mr-1"
                color="info"
                defaultChecked
                shape="pill"
                variant="outline"
              />
              <CSwitch
                className="mr-1"
                color="dark"
                defaultChecked
                shape="pill"
                variant="opposite"
              />
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel>Radios</CLabel>
            </CCol>
            <CCol md="9">
              <CFormGroup variant="checkbox">
                <CInputRadio className="form-check-input" id="radio1" name="radios" value="option1" />
                <CLabel variant="checkbox" htmlFor="radio1">Option 1</CLabel>
              </CFormGroup>
              <CFormGroup variant="checkbox">
                <CInputRadio className="form-check-input" id="radio2" name="radios" value="option2" />
                <CLabel variant="checkbox" htmlFor="radio2">Option 2</CLabel>
              </CFormGroup>
              <CFormGroup variant="checkbox">
                <CInputRadio className="form-check-input" id="radio3" name="radios" value="option3" />
                <CLabel variant="checkbox" htmlFor="radio3">Option 3</CLabel>
              </CFormGroup>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel>Inline Radios</CLabel>
            </CCol>
            <CCol md="9">
              <CFormGroup variant="custom-radio" inline>
                <CInputRadio custom id="inline-radio1" name="inline-radios" value="option1" />
                <CLabel variant="custom-checkbox" htmlFor="inline-radio1">One</CLabel>
              </CFormGroup>
              <CFormGroup variant="custom-radio" inline>
                <CInputRadio custom id="inline-radio2" name="inline-radios" value="option2" />
                <CLabel variant="custom-checkbox" htmlFor="inline-radio2">Two</CLabel>
              </CFormGroup>
              <CFormGroup variant="custom-radio" inline>
                <CInputRadio custom id="inline-radio3" name="inline-radios" value="option3" />
                <CLabel variant="custom-checkbox" htmlFor="inline-radio3">Three</CLabel>
              </CFormGroup>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3"><CLabel>Checkboxes</CLabel></CCol>
            <CCol md="9">
              <CFormGroup variant="checkbox" className="checkbox">
                <CInputCheckbox 
                  id="checkbox1" 
                  name="checkbox1" 
                  value="option1" 
                />
                <CLabel variant="checkbox" className="form-check-label" htmlFor="checkbox1">Option 1</CLabel>
              </CFormGroup>
              <CFormGroup variant="checkbox" className="checkbox">
                <CInputCheckbox id="checkbox2" name="checkbox2" value="option2" />
                <CLabel variant="checkbox" className="form-check-label" htmlFor="checkbox2">Option 2</CLabel>
              </CFormGroup>
              <CFormGroup variant="checkbox" className="checkbox">
                <CInputCheckbox id="checkbox3" name="checkbox3" value="option3" />
                <CLabel variant="checkbox" className="form-check-label" htmlFor="checkbox3">Option 3</CLabel>
              </CFormGroup>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel>Inline Checkboxes</CLabel>
            </CCol>
            <CCol md="9">
              <CFormGroup variant="custom-checkbox" inline>
                <CInputCheckbox 
                  custom 
                  id="inline-checkbox1" 
                  name="inline-checkbox1" 
                  value="option1" 
                />
                <CLabel variant="custom-checkbox" htmlFor="inline-checkbox1">One</CLabel>
              </CFormGroup>
              <CFormGroup variant="custom-checkbox" inline>
                <CInputCheckbox custom id="inline-checkbox2" name="inline-checkbox2" value="option2" />
                <CLabel variant="custom-checkbox" htmlFor="inline-checkbox2">Two</CLabel>
              </CFormGroup>
              <CFormGroup variant="custom-checkbox" inline>
                <CInputCheckbox custom id="inline-checkbox3" name="inline-checkbox3" value="option3" />
                <CLabel variant="custom-checkbox" htmlFor="inline-checkbox3">Three</CLabel>
              </CFormGroup>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CLabel col md="3" htmlFor="file-input">File input</CLabel>
            <CCol xs="12" md="9">
              <CInputFile id="file-input" name="file-input"/>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CCol md="3">
              <CLabel>Multiple File input</CLabel>
            </CCol>
            <CCol xs="12" md="9">
              <CInputFile 
                id="file-multiple-input" 
                name="file-multiple-input" 
                multiple
                custom
              />
              <CLabel htmlFor="file-multiple-input" variant="custom-file">
                Choose Files...
              </CLabel>
            </CCol>
          </CFormGroup>
          <CFormGroup row>
            <CLabel col md={3}>Custom file input</CLabel>
            <CCol xs="12" md="9">
              <CInputFile custom id="custom-file-input"/>
              <CLabel htmlFor="custom-file-input" variant="custom-file">
                Choose file...
              </CLabel>
            </CCol>
          </CFormGroup>
        </CForm>
      </CCardBody>
      <CCardFooter>
        <CButton type="submit" size="sm" color="primary"><CIcon name="cil-scrubber" /> Submit</CButton>
        <CButton type="reset" size="sm" color="danger"><CIcon name="cil-ban" /> Reset</CButton>
      </CCardFooter>
    </CCard>
  </CCol>

  );
}

const Calendar = () => {
  const [data, setData] = useState({
    lanes: [
      {
        cards: [
          {
            description: "2 Gallons of milk at the Deli store",
            id: "Card1",
            label: "2017-12-01",
            laneId: "SORTED_LANE",
            metadata: {
              completedAt: "2017-12-01T10:00:00Z",
              shortCode: "abc",
            },
            title: "Buy milk",
          },
          {
            description: "Sort out recyclable and waste as needed",
            id: "Card2",
            label: "2017-11-01",
            laneId: "SORTED_LANE",
            metadata: {
              completedAt: "2017-11-01T10:00:00Z",
              shortCode: "aaa",
            },
            title: "Dispose Garbage",
          },
          {
            description: "Can AI make memes?",
            id: "Card3",
            label: "2017-10-01",
            laneId: "SORTED_LANE",
            metadata: {
              completedAt: "2017-10-01T10:00:00Z",
              shortCode: "fa1",
            },
            title: "Write Blog",
          },
          {
            description: "Transfer to bank account",
            id: "Card4",
            label: "2017-09-01",
            laneId: "SORTED_LANE",
            metadata: {
              completedAt: "2017-09-01T10:00:00Z",
              shortCode: "ga2",
            },
            title: "Pay Rent",
          },
        ],
        currentPage: 1,
        id: "SORTED_LANE",
        label: "20/70",
        title: "Sorted Lane",
      },
    ],
  });

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

      <Board
        data={data}
        canAddLanes
        editLaneTitle
        editable
        onCardUpdate={function noRefCheck() {
          console.log("todoupdate");
        }}
        onLaneAdd={function noRefCheck() {
          console.log("todoAdd");
        }}
        onLaneUpdate={function noRefCheck() {
          console.log("todoupdate");
        }}
        onCardClick={async () => {
          const result = await CustomDialog(<CustomDialogContent />, {
            title: "Custom Dialog",
            showCloseIcon: true,
          });
        }}
      />
    </CCard>
  );
};
export default Calendar;
