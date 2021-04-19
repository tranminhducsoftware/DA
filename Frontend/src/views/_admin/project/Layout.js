import React, { useEffect, useState } from "react";
import {
    Redirect,
    Route,
    Switch
} from 'react-router-dom'
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
    CCollapse,
    CFade,
    CHeader,
    CHeaderNavItem,
    CHeaderNavLink

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
import TimeLine from "../timeline/TimeLine";
import Dashboard from "../dashboard/DashBoard";
import List from "../list/List";
import Overview from "../overview/Overview";
import Board from "../board/Board";


const Header = () => {
    const dispatch = useDispatch()
    const sidebarShow = useSelector(state => state.sidebarShow)

    const toggleSidebar = () => {
        const val = [true, 'responsive'].includes(sidebarShow) ? false : 'responsive'
        dispatch({ type: 'set', sidebarShow: val })
    }
    return (
        <CRow className="heder-project-wrapper">
            <CCol xl="10" className="heder-project-wrapper-col">
                <div className="heder-project-wrapper-icon-avatar">
                    <FontAwesomeIcon icon={faProjectDiagram} onClick={toggleSidebar} className="heder-project-icon-avatar" />
                </div>
                <div className="Wrapper-heder-project-top">
                    <h5 className="heder-project-top-name">Manager</h5>
                    <FontAwesomeIcon icon={faSortDown} onClick={toggleSidebar} className="heder-project-top-icon-detail" />
                    <FontAwesomeIcon icon={faStar} onClick={toggleSidebar} className="heder-project-top-icon-star" />
                    <span className="heder-project-top-text-status">Set status</span>
                </div>
                <div className="Wrapper-heder-project-bottom">
                    <CHeaderNav >
                        <CHeaderNavItem >
                            <CHeaderNavLink to="/_admin/project/overview">Overview</CHeaderNavLink>
                        </CHeaderNavItem>
                        <CHeaderNavItem >
                            <CHeaderNavLink to="/_admin/project/list">List</CHeaderNavLink>
                        </CHeaderNavItem>
                        <CHeaderNavItem >
                            <CHeaderNavLink to="/_admin/project/board">Board</CHeaderNavLink>
                        </CHeaderNavItem>
                        <CHeaderNavItem >
                            <CHeaderNavLink to="/_admin/project/timeline">Timeline</CHeaderNavLink>
                        </CHeaderNavItem>
                        <CHeaderNavItem >
                            <CHeaderNavLink to="/_admin/project/dashboard">Dashboard</CHeaderNavLink>
                        </CHeaderNavItem>
                    </CHeaderNav>

                </div>

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

const Layout = () => {
    return (
        <section>
            <Header />
            <section>
                <Switch>
                    <Route exact path="/_admin/project/dashboard">
                        <Dashboard />
                    </Route>
                    <Route path="/_admin/project/timeline">
                        <TimeLine />
                    </Route>
                    <Route path="/_admin/project/board">
                        <Board />
                    </Route>
                    <Route path="/_admin/project/list">
                        <List />
                    </Route>
                    <Route path="/_admin/project/overview">
                        <Overview />
                    </Route>
                </Switch>
            </section>
        </section>
    )
};
export default Layout;
