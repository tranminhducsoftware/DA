import React, { useState } from 'react'
import { useSelector, useDispatch } from 'react-redux'
import {
  CCreateElement,
  CSidebar,
  CSidebarBrand,
  CSidebarNav,
  CSidebarNavDivider,
  CSidebarNavTitle,
  CSidebarMinimizer,
  CSidebarNavDropdown,
  CSidebarNavItem,
  CButton,
  CCard,
  CCardBody,
  CCardFooter,
  CCardHeader,
  CCol,
  CCollapse,
  CRow,
  CImg
} from '@coreui/react'

import CIcon from '@coreui/icons-react'
import { faCheckSquare, faPlus } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

// sidebar nav config
import navigation from './_nav'

const Favorites = () => {
  const [collapse, setCollapse] = useState(false)
  const toggle = (e) => {
    setCollapse(!collapse)
    e.preventDefault()
  }
  return (
    <CCard className="card-bg-dark">
      <CCardHeader onClick={toggle} className="color-dark">
        Favorites
      </CCardHeader>
      <CCollapse show={collapse}>
        <CCardBody className="body-card-nav">
          <span style={{ "font-size": "12px", "color": "#6f7782" }}>Star projects for easy access</span>
        </CCardBody>
      </CCollapse>
    </CCard>
  )
}

const Projects = () => {
  return (
    <CCard className="card-bg-dark">
      <CCardHeader className="color-dark header-field-nav" style={{ position: "relative" }}>
        <CButton className="btn-field-nav">IT</CButton>
        <FontAwesomeIcon icon={faPlus} className="icon-plus-nav" />
      </CCardHeader>
      <CCardBody className="body-card-nav">
        <CRow>
          <CCol xl="6" style={{ "padding-left": "7px", "padding-right": 0 }}>
            <div className="c-avatar avatar-nav">
              <span style={{ background: "#321fdb" }}>TL</span>
            </div>
            <div className="c-avatar avatar-nav">
              <span style={{ background: "#321fdb" }}>MD</span>
            </div>
            <div className="c-avatar avatar-nav" >
              <span style={{ background: "#e55353" }}>HL</span>
            </div>
          </CCol>
          <CCol xl="6" style={{ "padding-left": "0px" }}>
            <CButton className="btn-invite-people-nav">
              <FontAwesomeIcon icon={faPlus} />
              <span style={{ marginLeft: "5px" }}>Invite people</span>
            </CButton>
          </CCol>
          <CCol xl="12" style={{ padding: "0px" }} >
            <ul className="ul-project-nav">
              <li className="li-project-nav">
                <div className="li_div-project-nav"></div>
                <span>IT requests</span>
              </li>
              <li className="li-project-nav">
                <div className="li_div-project-nav"></div>
                <span>DA</span>
              </li>
              <li className="li-project-nav">
                <div className="li_div-project-nav"></div>
                <span>Manager</span>
              </li>
            </ul>
          </CCol>
        </CRow>
      </CCardBody>
    </CCard>
  )
}

const Support = () => {
  return (
    <ul className="ul-support-nav">
      <li className="li-support-nav li-invite-nav">
        <CImg
          src="https://d3ki9tyy5l5ruj.cloudfront.net/obj/8a613bc1f8e95548a8ccf856b77261a748868a44/illustration_invite_teammates.svg"
          className="c-avatar-img img-invite-nav"
          alt="admin@bootstrapmaster.com"
        />
        <span className="text-support-nav">Invite teammates</span>
      </li>
      <li className="li-support-nav">
        <span className="icon-support-nav">?</span>
        <span className="text-support-nav">Help & getting started</span>
      </li>
    </ul>
  )
}


const TheSidebar = () => {
  const dispatch = useDispatch()
  const show = useSelector(state => state.sidebarShow)

  return (
    <CSidebar
      show={show}
      className="background-dark"
      onShowChange={(val) => dispatch({ type: 'set', sidebarShow: val })}
    >
      <CSidebarBrand className="d-md-down-none" to="/">
        <CImg
          src="https://i.pinimg.com/236x/28/fa/1d/28fa1dcb383006349990f771dc2a5db5--dog-logo-design-cat-design.jpg"
          className="c-avatar-img img-invite-nav"
          style={{
            width: "35px",
            padding: "0px",
            "margin-left": "-50px"
          }}
          alt="admin@bootstrapmaster.com"
        />
        <h5>METALON</h5>
      </CSidebarBrand>
      <CSidebarNav>

        <CCreateElement
          items={navigation}
          components={{
            CSidebarNavDivider,
            CSidebarNavDropdown,
            CSidebarNavItem,
            CSidebarNavTitle
          }}
        />
        <Favorites />
        <Projects />
        <Support />
      </CSidebarNav>
      <CSidebarMinimizer className="c-d-md-down-none" />
    </CSidebar>
  )
}

export default React.memo(TheSidebar)
