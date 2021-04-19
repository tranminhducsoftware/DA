import React, { useEffect, useState } from "react";
import {
  CRow,
  CCol,
  CCard,
  CCardHeader,
  CCardBody,
  CSubheader,
  CLink,
  CContainer,
  CWidgetProgressIcon,
  CButton,
  CFormGroup,
  CLabel,
  CInput,
  CHeaderNav,
  CToggler,
  CHeaderBrand,
  CCollapse
} from "@coreui/react";
import CIcon from "@coreui/icons-react";
import {
  TheHeaderDropdown,
  TheHeaderDropdownMssg,
  TheHeaderDropdownNotif,
} from '../../../containers/index';
import { useSelector, useDispatch } from 'react-redux'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faAlignJustify, faSortDown, faCheckCircle, faStar, faProjectDiagram, faPlus } from '@fortawesome/free-solid-svg-icons'
import { useHistory } from "react-router-dom";

const Header = () => {
  const dispatch = useDispatch()
  const sidebarShow = useSelector(state => state.sidebarShow)

  const toggleSidebar = () => {
    const val = [true, 'responsive'].includes(sidebarShow) ? false : 'responsive'
    dispatch({ type: 'set', sidebarShow: val })
  }
  return (
    <CRow className="header-home">
      <CCol xl="10" className="header-home-col">
        <span className="header-home-span-icon">
          <FontAwesomeIcon icon={faAlignJustify} onClick={toggleSidebar} />
        </span>
        <h4 className="header-home-text">Home</h4>
      </CCol>
      <CCol xl="2">
        <CHeaderNav className="px-3" style={{ "float": "right" }}>
          <TheHeaderDropdownNotif />
          <TheHeaderDropdownMssg />
          <TheHeaderDropdown />
        </CHeaderNav>
      </CCol>
    </CRow>
  )
}

const TaskDueSoon = () => {
  const [collapse, setCollapse] = useState(true)

  const toggle = (e) => {
    setCollapse(!collapse)
    e.preventDefault()
  }

  return (
    <CCard style={{ border: 0 }}>
      <CCardHeader className="task-due-header">
        <CRow>
          <CCol xl="9">
            <span onClick={toggle} className="task-due-header-wrapper-text">
              <FontAwesomeIcon icon={faSortDown} className="task-due-header-icon" />
              <h5>Tasks Due Soon</h5>
            </span>
          </CCol>
          <CCol xl="3">
            <CLink className="task-due-headerlink">See all my tasks</CLink>
          </CCol>
        </CRow>

      </CCardHeader>
      <CCollapse show={collapse} className="task-due-body-wrapper" style={{ "marginBottom": "20px" }}>
        <CCardBody className="task-due-body">
          <ul className="task-due-body-ul">
            <li className="task-due-body-li">
              <FontAwesomeIcon icon={faCheckCircle} className="task-due-body-li-icon" />
              <span className="task-due-body-li-name">New hire desk setup</span>
              <span className="task-due-body-li-right">
                <span className="task-due-body-li-right-project">DA</span>
                <span className="task-due-body-li-right-time">Tomorrow</span>
              </span>
            </li>
            <li className="task-due-body-li">
              <FontAwesomeIcon icon={faCheckCircle} className="task-due-body-li-icon" />
              <span className="task-due-body-li-name">Task 1</span>
              <span className="task-due-body-li-right">
                <span className="task-due-body-li-right-project">DA</span>
                <span className="task-due-body-li-right-time">Tomorrow</span>
              </span>
            </li>
            <li className="task-due-body-li">
              <FontAwesomeIcon icon={faCheckCircle} className="task-due-body-li-icon" />
              <span className="task-due-body-li-name">Task 2</span>
              <span className="task-due-body-li-right">
                <span className="task-due-body-li-right-project">DA</span>
                <span className="task-due-body-li-right-time">Tomorrow</span>
              </span>
            </li>
          </ul>
        </CCardBody>
      </CCollapse>

    </CCard>
  )
}

const Favorites = () => {
  const [collapse, setCollapse] = useState(true)

  const toggle = (e) => {
    setCollapse(!collapse)
    e.preventDefault()
  }
  return (
    <CCard style={{ border: 0 }}>
      <CCardHeader className="task-due-header" style={{ "marginTop": "0px" }}>
        <CRow>
          <CCol xl="9">
            <span onClick={toggle} className="task-due-header-wrapper-text">
              <FontAwesomeIcon icon={faSortDown} className="task-due-header-icon" />
              <h5>Favorites</h5>
            </span>
          </CCol>

        </CRow>

      </CCardHeader>
      <CCollapse show={collapse} className="task-due-body-wrapper" style={{ border: "0px" }}>
        <CCardBody className="task-due-body" style={{ border: "0px" }}>
          <ul className="project-recent-ul">
            <li className="project-recent-li">
              <div className="project-recent-wrapper">
                <FontAwesomeIcon icon={faStar} className="project-recent-icon-start" />
                <FontAwesomeIcon icon={faProjectDiagram} className="project-recent-icon-avatar" />
                <div className="project-recent-owner">TL</div>
              </div>
              <h6 className="project-recent-name">DA</h6>
            </li>
          </ul>

        </CCardBody>
      </CCollapse>

    </CCard>
  )
}

const RecentProject = () => {
  const [collapse, setCollapse] = useState(true)
  const history = useHistory();
  const toggle = (e) => {
    setCollapse(!collapse)
    e.preventDefault()
  }

  const handleClick = () => {
    history.push("/_admin/project/overview");
  }

  return (
    <CCard style={{ border: 0 }}>
      <CCardHeader className="task-due-header" style={{ "marginTop": "0px" }}>
        <CRow>
          <CCol xl="9">
            <span onClick={toggle} className="task-due-header-wrapper-text">
              <FontAwesomeIcon icon={faSortDown} className="task-due-header-icon" />
              <h5>Recent Projects</h5>
            </span>
          </CCol>

        </CRow>

      </CCardHeader>
      <CCollapse show={collapse} className="task-due-body-wrapper" style={{ border: "0px" }}>
        <CCardBody className="task-due-body" style={{ border: "0px" }}>
          <ul className="project-recent-ul">
            <li onClick={handleClick} className="project-recent-li">
              <div className="project-recent-wrapper">
                <FontAwesomeIcon icon={faStar} className="project-recent-icon-start" />
                <FontAwesomeIcon icon={faProjectDiagram} className="project-recent-icon-avatar" />
                <div className="project-recent-owner">TL</div>
              </div>
              <h6 className="project-recent-name">DA</h6>
            </li>

            <li className="project-recent-li">
              <div className="project-recent-wrapper">
                <FontAwesomeIcon icon={faStar} className="project-recent-icon-start" />
                <FontAwesomeIcon icon={faProjectDiagram} className="project-recent-icon-avatar" />
                <div className="project-recent-owner">TL</div>
              </div>
              <h6 className="project-recent-name">Manager</h6>
            </li>

            <li className="project-recent-li">
              <div className="project-recent-wrapper">
                <FontAwesomeIcon icon={faStar} className="project-recent-icon-start" />
                <FontAwesomeIcon icon={faProjectDiagram} className="project-recent-icon-avatar" />
                <div className="project-recent-owner">TL</div>
              </div>
              <h6 className="project-recent-name">IT requests</h6>
            </li>

            <li className="project-recent-li">
              <div className="project-recent-wrapper new-project-wrapper">
                <FontAwesomeIcon icon={faPlus} className="project-recent-icon-avatar new-project-avatar" />
              </div>
              <h6 className="project-recent-name">New Project</h6>
            </li>
          </ul>

        </CCardBody>
      </CCollapse>

    </CCard>
  )
}
const Home = () => {
  return (
    <section>
      <Header />
      <CRow>
        <CCol xl="3"></CCol>
        <CCol xl="6">
          <TaskDueSoon />
          <Favorites />
          <RecentProject />
        </CCol>
        <CCol xl="3"></CCol>
      </CRow>

    </section>
  )
};
export default Home;
